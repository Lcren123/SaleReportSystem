using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using SaleReportSystem.Class;
using System.DirectoryServices.ActiveDirectory;
using Application = System.Windows.Forms.Application;

namespace SaleReportSystem
{
    public partial class MainForm : Form
    {
        readonly string sqlConnection = "INSERT CONNECTION STRING HERE";
        private string userId;
        List<MonthComboboxItem> monthlist = new List<MonthComboboxItem>
            {
                new MonthComboboxItem { Id = 1, Months = "January" },new MonthComboboxItem { Id = 2, Months = "February" },new MonthComboboxItem { Id = 3, Months = "March" },new MonthComboboxItem { Id = 4, Months = "April" },new MonthComboboxItem { Id = 5, Months = "May" },new MonthComboboxItem { Id = 6, Months = "June" },
                new MonthComboboxItem { Id = 7, Months = "July" },new MonthComboboxItem { Id = 8, Months = "August" },new MonthComboboxItem { Id = 9, Months = "September" },new MonthComboboxItem { Id = 10, Months = "October" },new MonthComboboxItem { Id = 11, Months = "November" },new MonthComboboxItem { Id = 12, Months = "December" }
            };

        public MainForm(string ID)
        {
            InitializeComponent();
            userId = ID;
            PopulateSqlData();
        }

        private void PopulateSqlData()
        {
            //populate Combo box
            comboBox_Year.DataSource = Enumerable.Range(1950, DateTime.UtcNow.Year - 1949).Reverse().ToList();
            SqlConnection myConnection = new SqlConnection(sqlConnection);
            myConnection.Open();
            SqlCommand cmd = new SqlCommand("Select loginId from dbo.UserProfile", myConnection);
            List<string> agentList = new List<string>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    agentList.Add(reader["loginId"].ToString());
                }
            }
            comboBox_Agent.DataSource = agentList;
            myConnection.Close();
            comboBox_Month.DataSource = monthlist;
            comboBox_Month.ValueMember = "Id";
            comboBox_Month.DisplayMember = "Months";

            //populate Transaction Table
            myConnection = new SqlConnection(sqlConnection);
            myConnection.Open();
            cmd = new SqlCommand("SELECT * FROM dbo.SalesTransaction WHERE userId = @userId", myConnection);
            cmd.Parameters.AddWithValue("userId", userId);
            cmd.ExecuteReader();
            myConnection.Close();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            TransactionTable.DataSource = dataTable;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Sales Record System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #region Transaction Record
        private void buttonUpdateRecord_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtemp = TransactionTable.DataSource as DataTable;

                SqlConnection myConnection = new SqlConnection(sqlConnection);
                myConnection.Open();

                SqlCommand command = new SqlCommand("dbo.SalesTransactionManagement", myConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@temptable", dtemp).SqlDbType = SqlDbType.Structured;

                //Execute
                var result = command.ExecuteNonQuery();
                DialogResult iSuccess = MessageBox.Show("Record Update successful", "Sales Record System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                DialogResult iFailure = MessageBox.Show("Something went wrong, please try again!", "Sales Record System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            //hide all other middle panel
            panel_YearlyReport.Visible = false;
            panel_MonthlyReport.Visible = false;
            panel_report.Visible = false;
            //show title and panel
            panel_Record.Visible = true;
            TransactionTable.Visible = true;
            button_UpdateRecord.Visible = true;



        }
        #endregion


        #region Report
        private void buttonReport_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(sqlConnection);
            myConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT userRole FROM dbo.UserProfile WHERE loginId = @userId", myConnection);
            cmd.Parameters.AddWithValue("userId", userId);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    var result = reader["userRole"].ToString();
                    if (result == "manager")
                    {
                        panel_Record.Visible = false;
                        TransactionTable.Visible = false;
                        button_UpdateRecord.Visible = false;

                        panel_YearlyReport.Visible = true;
                        panel_MonthlyReport.Visible = true;
                        panel_report.Visible = true;
                    }
                    else
                    {
                        DialogResult iFailure = MessageBox.Show("User has no access to this page!", "Sales Record System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }


        }

        private void buttonYearlyReport_Click(object sender, EventArgs e)
        {
            try
            {
                int year = Convert.ToInt32(comboBox_Year.SelectedItem);
                List<SalesSummaryReport> list = new List<SalesSummaryReport>();
                SqlConnection myConnection = new SqlConnection(sqlConnection);
                myConnection.Open();

                SqlCommand command = new SqlCommand("dbo.YearlyReportSP", myConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@managerId", userId);
                command.Parameters.AddWithValue("@year", year);

                //Execute

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SalesSummaryReport { Month = reader["Month"].ToString(), Amount = Convert.ToDouble(reader["Amount"]) });
                    }
                }
                dataGridView1.DataSource = list;
            }
            catch (Exception)
            {
                DialogResult iFailure = MessageBox.Show("Something went wrong, please try again!", "Sales Record System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void buttonMonthlyReport_Click(object sender, EventArgs e)
        {
            try
            {
                MonthComboboxItem month = comboBox_Month.SelectedItem as MonthComboboxItem;
                string agentId = comboBox_Agent.SelectedItem.ToString();
                List<SalesSummaryReport> list = new List<SalesSummaryReport>();
                SqlConnection myConnection = new SqlConnection(sqlConnection);
                myConnection.Open();

                SqlCommand command = new SqlCommand("dbo.AgentMonthlyReportSP", myConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@agentId", agentId);
                command.Parameters.AddWithValue("@month", month.Id);
                command.Parameters.AddWithValue("@year", DateTime.Now.Year);
                //Execute
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SalesSummaryReport { UserName = reader["Agent"].ToString(), Amount = Convert.ToDouble(reader["Amount"]) });
                    }
                }

                dataGridView2.DataSource = list;

            }
            catch (Exception)
            {
                DialogResult iFailure = MessageBox.Show("Something went wrong, please try again!", "Sales Record System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion
    }
}
