using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleReportSystem
{
    public partial class LoginForm : Form
    {
        readonly string sqlConnection = "Data Source=DESKTOP-GOA7909\\SQLEXPRESS;Initial Catalog=WebSalesDb;Integrated Security=True";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton(object sender, EventArgs e)
        {
            string userId = null;
            var conn = new SqlConnection(sqlConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.loginAuthorization", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@userName", txt_UserName.Text));
            cmd.Parameters.Add(new SqlParameter("@password", txt_Password.Text));


            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                userId = result["loginId"].ToString();
            }

            conn.Close();
            if (userId != null)
            {
                this.Hide();
                new MainForm(userId).Show();
            }
            else
            {
                MessageBox.Show("The user name or password you entered is incorrect, please try again!");
                txt_Password.Clear();
                txt_UserName.Clear();
                txt_UserName.Focus();
            }
        }

        private void ClearButton(object sender, EventArgs e)
        {
            txt_Password.Clear();
            txt_UserName.Clear();
            txt_UserName.Focus();
        }
    }
}
