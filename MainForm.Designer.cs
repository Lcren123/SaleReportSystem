
using System.Linq;
using System;

namespace SaleReportSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            button4 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            Exit = new System.Windows.Forms.Button();
            button_UpdateRecord = new System.Windows.Forms.Button();
            TransactionTable = new System.Windows.Forms.DataGridView();
            saleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            salesItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            salesDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updatedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            salesTranscationBindingSource = new System.Windows.Forms.BindingSource(components);
            panel_Record = new System.Windows.Forms.Panel();
            label_Record = new System.Windows.Forms.Label();
            dataSet11 = new DataSet1();
            panel_YearlyReport = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            comboBox_Year = new System.Windows.Forms.ComboBox();
            button3 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            salesSummaryReportBindingSource = new System.Windows.Forms.BindingSource(components);
            panel_MonthlyReport = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            comboBox_Month = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            comboBox_Agent = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            button5 = new System.Windows.Forms.Button();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label2 = new System.Windows.Forms.Label();
            panel_report = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TransactionTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesTranscationBindingSource).BeginInit();
            panel_Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataSet11).BeginInit();
            panel_YearlyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesSummaryReportBindingSource).BeginInit();
            panel_MonthlyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel_report.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1370, 127);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(302, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(805, 91);
            label1.TabIndex = 0;
            label1.Text = " Sales Report System";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(Exit);
            panel2.Location = new System.Drawing.Point(0, 622);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1370, 127);
            panel2.TabIndex = 0;
            // 
            // button4
            // 
            button4.AccessibleName = "Btn_record";
            button4.BackColor = System.Drawing.SystemColors.GrayText;
            button4.Font = new System.Drawing.Font("Sans Serif Collection", 14.9999981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button4.Location = new System.Drawing.Point(70, 36);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(207, 54);
            button4.TabIndex = 0;
            button4.Text = "Record";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonRecord_Click;
            // 
            // button2
            // 
            button2.AccessibleName = "Btn_GenerateReport";
            button2.BackColor = System.Drawing.SystemColors.GrayText;
            button2.Font = new System.Drawing.Font("Sans Serif Collection", 14.9999981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button2.Location = new System.Drawing.Point(427, 36);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(207, 54);
            button2.TabIndex = 0;
            button2.Text = "Report";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonReport_Click;
            // 
            // Exit
            // 
            Exit.AccessibleName = "BtnExit";
            Exit.BackColor = System.Drawing.SystemColors.GrayText;
            Exit.Font = new System.Drawing.Font("Sans Serif Collection", 14.9999981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            Exit.Location = new System.Drawing.Point(1097, 36);
            Exit.Name = "Exit";
            Exit.Size = new System.Drawing.Size(207, 54);
            Exit.TabIndex = 0;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += buttonExit_Click;
            // 
            // button_UpdateRecord
            // 
            button_UpdateRecord.AccessibleName = "BtnUpdate";
            button_UpdateRecord.BackColor = System.Drawing.SystemColors.GrayText;
            button_UpdateRecord.Font = new System.Drawing.Font("Sans Serif Collection", 14.9999981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_UpdateRecord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button_UpdateRecord.Location = new System.Drawing.Point(1079, 552);
            button_UpdateRecord.Name = "button_UpdateRecord";
            button_UpdateRecord.Size = new System.Drawing.Size(279, 54);
            button_UpdateRecord.TabIndex = 0;
            button_UpdateRecord.Text = "Update Record";
            button_UpdateRecord.UseVisualStyleBackColor = false;
            button_UpdateRecord.Click += buttonUpdateRecord_Click;
            // 
            // TransactionTable
            // 
            TransactionTable.AutoGenerateColumns = false;
            TransactionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransactionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { saleIdDataGridViewTextBoxColumn, salesItemDataGridViewTextBoxColumn, salesDateDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, updatedDateDataGridViewTextBoxColumn });
            TransactionTable.DataSource = salesTranscationBindingSource;
            TransactionTable.Location = new System.Drawing.Point(0, 216);
            TransactionTable.Name = "TransactionTable";
            TransactionTable.RowTemplate.Height = 25;
            TransactionTable.Size = new System.Drawing.Size(1370, 400);
            TransactionTable.TabIndex = 1;
            // 
            // saleIdDataGridViewTextBoxColumn
            // 
            saleIdDataGridViewTextBoxColumn.DataPropertyName = "SaleId";
            saleIdDataGridViewTextBoxColumn.HeaderText = "SaleId";
            saleIdDataGridViewTextBoxColumn.Name = "saleIdDataGridViewTextBoxColumn";
            // 
            // salesItemDataGridViewTextBoxColumn
            // 
            salesItemDataGridViewTextBoxColumn.DataPropertyName = "SalesItem";
            salesItemDataGridViewTextBoxColumn.HeaderText = "SalesItem";
            salesItemDataGridViewTextBoxColumn.Name = "salesItemDataGridViewTextBoxColumn";
            // 
            // salesDateDataGridViewTextBoxColumn
            // 
            salesDateDataGridViewTextBoxColumn.DataPropertyName = "SalesDate";
            salesDateDataGridViewTextBoxColumn.HeaderText = "SalesDate";
            salesDateDataGridViewTextBoxColumn.Name = "salesDateDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // updatedDateDataGridViewTextBoxColumn
            // 
            updatedDateDataGridViewTextBoxColumn.DataPropertyName = "UpdatedDate";
            updatedDateDataGridViewTextBoxColumn.HeaderText = "UpdatedDate";
            updatedDateDataGridViewTextBoxColumn.Name = "updatedDateDataGridViewTextBoxColumn";
            // 
            // salesTranscationBindingSource
            // 
            salesTranscationBindingSource.DataSource = typeof(Class.SalesTranscation);
            // 
            // panel_Record
            // 
            panel_Record.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel_Record.Controls.Add(label_Record);
            panel_Record.Location = new System.Drawing.Point(12, 133);
            panel_Record.Name = "panel_Record";
            panel_Record.Size = new System.Drawing.Size(556, 77);
            panel_Record.TabIndex = 2;
            // 
            // label_Record
            // 
            label_Record.AccessibleName = "title_Record";
            label_Record.AutoSize = true;
            label_Record.Font = new System.Drawing.Font("Sans Serif Collection", 23.9999962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label_Record.Location = new System.Drawing.Point(3, 0);
            label_Record.Name = "label_Record";
            label_Record.Size = new System.Drawing.Size(529, 79);
            label_Record.TabIndex = 0;
            label_Record.Text = "Transcation Record";
            // 
            // dataSet11
            // 
            dataSet11.DataSetName = "DataSet1";
            dataSet11.Namespace = "http://tempuri.org/DataSet1.xsd";
            dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel_YearlyReport
            // 
            panel_YearlyReport.BackColor = System.Drawing.SystemColors.ControlDark;
            panel_YearlyReport.Controls.Add(label5);
            panel_YearlyReport.Controls.Add(comboBox_Year);
            panel_YearlyReport.Controls.Add(button3);
            panel_YearlyReport.Controls.Add(label3);
            panel_YearlyReport.Controls.Add(dataGridView1);
            panel_YearlyReport.Location = new System.Drawing.Point(12, 234);
            panel_YearlyReport.Name = "panel_YearlyReport";
            panel_YearlyReport.Size = new System.Drawing.Size(609, 382);
            panel_YearlyReport.TabIndex = 3;
            panel_YearlyReport.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(121, 75);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 29);
            label5.TabIndex = 2;
            label5.Text = "Year";
            // 
            // comboBox_Year
            // 
            comboBox_Year.AccessibleName = "combobox_year";
            comboBox_Year.FormattingEnabled = true;
            comboBox_Year.Location = new System.Drawing.Point(178, 75);
            comboBox_Year.Name = "comboBox_Year";
            comboBox_Year.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            comboBox_Year.Size = new System.Drawing.Size(121, 23);
            comboBox_Year.TabIndex = 1;
            comboBox_Year.Tag = "Year";
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.GrayText;
            button3.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button3.Location = new System.Drawing.Point(178, 130);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(121, 39);
            button3.TabIndex = 0;
            button3.Text = "Generate";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonYearlyReport_Click;
            // 
            // label3
            // 
            label3.AccessibleName = "title_Record";
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Sans Serif Collection", 14.2499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(17, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(340, 47);
            label3.TabIndex = 0;
            label3.Text = "Yearly Summary Report";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { monthDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = salesSummaryReportBindingSource;
            dataGridView1.Location = new System.Drawing.Point(363, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(243, 315);
            dataGridView1.TabIndex = 0;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            monthDataGridViewTextBoxColumn.HeaderText = "Month";
            monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            // 
            // salesSummaryReportBindingSource
            // 
            salesSummaryReportBindingSource.DataSource = typeof(Class.SalesSummaryReport);
            // 
            // panel_MonthlyReport
            // 
            panel_MonthlyReport.BackColor = System.Drawing.SystemColors.ControlDark;
            panel_MonthlyReport.Controls.Add(label7);
            panel_MonthlyReport.Controls.Add(comboBox_Month);
            panel_MonthlyReport.Controls.Add(label6);
            panel_MonthlyReport.Controls.Add(comboBox_Agent);
            panel_MonthlyReport.Controls.Add(label4);
            panel_MonthlyReport.Controls.Add(button5);
            panel_MonthlyReport.Controls.Add(dataGridView2);
            panel_MonthlyReport.Location = new System.Drawing.Point(742, 231);
            panel_MonthlyReport.Name = "panel_MonthlyReport";
            panel_MonthlyReport.Size = new System.Drawing.Size(616, 382);
            panel_MonthlyReport.TabIndex = 3;
            panel_MonthlyReport.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(116, 105);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(62, 29);
            label7.TabIndex = 5;
            label7.Text = "Month";
            // 
            // comboBox_Month
            // 
            comboBox_Month.AccessibleName = "combobox_Month";
            comboBox_Month.FormattingEnabled = true;
            comboBox_Month.Location = new System.Drawing.Point(173, 105);
            comboBox_Month.Name = "comboBox_Month";
            comboBox_Month.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            comboBox_Month.Size = new System.Drawing.Size(121, 23);
            comboBox_Month.TabIndex = 4;
            comboBox_Month.Tag = "Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(116, 67);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(60, 29);
            label6.TabIndex = 5;
            label6.Text = "Agent";
            // 
            // comboBox_Agent
            // 
            comboBox_Agent.AccessibleName = "combobox_Agent";
            comboBox_Agent.FormattingEnabled = true;
            comboBox_Agent.Location = new System.Drawing.Point(173, 67);
            comboBox_Agent.Name = "comboBox_Agent";
            comboBox_Agent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            comboBox_Agent.Size = new System.Drawing.Size(121, 23);
            comboBox_Agent.TabIndex = 4;
            comboBox_Agent.Tag = "Year";
            // 
            // label4
            // 
            label4.AccessibleName = "title_Record";
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Sans Serif Collection", 14.2499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(20, 6);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(311, 47);
            label4.TabIndex = 0;
            label4.Text = "Agent Monthly Report";
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.SystemColors.GrayText;
            button5.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button5.Location = new System.Drawing.Point(173, 150);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(121, 39);
            button5.TabIndex = 3;
            button5.Text = "Generate";
            button5.UseVisualStyleBackColor = false;
            button5.Click += buttonMonthlyReport_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { UserName, dataGridViewTextBoxColumn2 });
            dataGridView2.DataSource = salesSummaryReportBindingSource;
            dataGridView2.Location = new System.Drawing.Point(366, 67);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new System.Drawing.Size(243, 312);
            dataGridView2.TabIndex = 1;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "UserName";
            UserName.Name = "UserName";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Amount";
            dataGridViewTextBoxColumn2.HeaderText = "Amount";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label2
            // 
            label2.AccessibleName = "title_Record";
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sans Serif Collection", 23.9999962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(462, 79);
            label2.TabIndex = 0;
            label2.Text = "Summary Report";
            // 
            // panel_report
            // 
            panel_report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel_report.Controls.Add(label2);
            panel_report.Location = new System.Drawing.Point(742, 133);
            panel_report.Name = "panel_report";
            panel_report.Size = new System.Drawing.Size(556, 77);
            panel_report.TabIndex = 2;
            panel_report.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1370, 761);
            Controls.Add(panel_MonthlyReport);
            Controls.Add(panel_YearlyReport);
            Controls.Add(button_UpdateRecord);
            Controls.Add(panel_report);
            Controls.Add(panel_Record);
            Controls.Add(TransactionTable);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sales Report System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TransactionTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesTranscationBindingSource).EndInit();
            panel_Record.ResumeLayout(false);
            panel_Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataSet11).EndInit();
            panel_YearlyReport.ResumeLayout(false);
            panel_YearlyReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesSummaryReportBindingSource).EndInit();
            panel_MonthlyReport.ResumeLayout(false);
            panel_MonthlyReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel_report.ResumeLayout(false);
            panel_report.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TransactionTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salesTranscationBindingSource;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel_Record;
        private System.Windows.Forms.Label label_Record;
        private System.Windows.Forms.Button button_UpdateRecord;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Panel panel_YearlyReport;
        private System.Windows.Forms.Panel panel_MonthlyReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource salesSummaryReportBindingSource;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Agent;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_report;
    }
}

