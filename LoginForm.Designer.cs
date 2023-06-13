namespace SaleReportSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginPanel = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            txt_Password = new System.Windows.Forms.TextBox();
            txt_UserName = new System.Windows.Forms.TextBox();
            panel5 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            login = new System.Windows.Forms.Label();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            loginPanel.Controls.Add(button2);
            loginPanel.Controls.Add(button1);
            loginPanel.Controls.Add(txt_Password);
            loginPanel.Controls.Add(txt_UserName);
            loginPanel.Controls.Add(panel5);
            loginPanel.Controls.Add(panel4);
            loginPanel.Controls.Add(label3);
            loginPanel.Controls.Add(label2);
            loginPanel.Controls.Add(login);
            loginPanel.Location = new System.Drawing.Point(1, 3);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new System.Drawing.Size(448, 289);
            loginPanel.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            button2.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button2.Location = new System.Drawing.Point(261, 202);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(173, 45);
            button2.TabIndex = 8;
            button2.Text = "Clear Text";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ClearButton;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            button1.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button1.Location = new System.Drawing.Point(135, 202);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(104, 45);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += LoginButton;
            // 
            // txt_Password
            // 
            txt_Password.BackColor = System.Drawing.SystemColors.ControlDark;
            txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Password.Location = new System.Drawing.Point(135, 161);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new System.Drawing.Size(299, 19);
            txt_Password.TabIndex = 6;
            // 
            // txt_UserName
            // 
            txt_UserName.BackColor = System.Drawing.SystemColors.ControlDark;
            txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_UserName.Location = new System.Drawing.Point(135, 102);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new System.Drawing.Size(299, 19);
            txt_UserName.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel5.Location = new System.Drawing.Point(135, 183);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(300, 1);
            panel5.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel4.Location = new System.Drawing.Point(135, 125);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(300, 1);
            panel4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(28, 155);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(92, 29);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(28, 96);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 29);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // login
            // 
            login.AutoSize = true;
            login.BackColor = System.Drawing.SystemColors.GrayText;
            login.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            login.Location = new System.Drawing.Point(135, 16);
            login.Name = "login";
            login.Size = new System.Drawing.Size(188, 46);
            login.TabIndex = 0;
            login.Text = "Welcome";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(451, 292);
            Controls.Add(loginPanel);
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sales Report System";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label login;
    }
}