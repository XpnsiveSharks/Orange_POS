namespace Orange_POS.Views.AdminViews.AdminViewUserControls
{
    partial class SettingsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingsIndexPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteAccount = new Guna.UI2.WinForms.Guna2Button();
            this.CreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.ChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CurrentUsernameSettings = new System.Windows.Forms.Label();
            this.Logout = new Guna.UI2.WinForms.Guna2Button();
            this.SettingsIndexPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsIndexPanel
            // 
            this.SettingsIndexPanel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsIndexPanel.BorderRadius = 25;
            this.SettingsIndexPanel.Controls.Add(this.Logout);
            this.SettingsIndexPanel.Controls.Add(this.label1);
            this.SettingsIndexPanel.Controls.Add(this.DeleteAccount);
            this.SettingsIndexPanel.Controls.Add(this.CreateAccount);
            this.SettingsIndexPanel.Controls.Add(this.ChangePassword);
            this.SettingsIndexPanel.Controls.Add(this.label4);
            this.SettingsIndexPanel.Controls.Add(this.label5);
            this.SettingsIndexPanel.Controls.Add(this.CurrentUsernameSettings);
            this.SettingsIndexPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.SettingsIndexPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.SettingsIndexPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.SettingsIndexPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.SettingsIndexPanel.Location = new System.Drawing.Point(16, 14);
            this.SettingsIndexPanel.Name = "SettingsIndexPanel";
            this.SettingsIndexPanel.Size = new System.Drawing.Size(732, 437);
            this.SettingsIndexPanel.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(259, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 41);
            this.label1.TabIndex = 42;
            this.label1.Text = "User Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeleteAccount
            // 
            this.DeleteAccount.BorderRadius = 18;
            this.DeleteAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.DeleteAccount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DeleteAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.DeleteAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.DeleteAccount.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.DeleteAccount.Location = new System.Drawing.Point(253, 299);
            this.DeleteAccount.Name = "DeleteAccount";
            this.DeleteAccount.Size = new System.Drawing.Size(219, 39);
            this.DeleteAccount.TabIndex = 41;
            this.DeleteAccount.Text = "Delete Account";
            this.DeleteAccount.Click += new System.EventHandler(this.DeleteAccount_Click);
            // 
            // CreateAccount
            // 
            this.CreateAccount.BorderRadius = 18;
            this.CreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateAccount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CreateAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateAccount.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateAccount.Location = new System.Drawing.Point(253, 208);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(219, 39);
            this.CreateAccount.TabIndex = 39;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // ChangePassword
            // 
            this.ChangePassword.BorderRadius = 18;
            this.ChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.ChangePassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.ChangePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.ChangePassword.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.ChangePassword.Location = new System.Drawing.Point(253, 253);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(219, 39);
            this.ChangePassword.TabIndex = 34;
            this.ChangePassword.Text = "Change Passwod";
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.label4.Location = new System.Drawing.Point(295, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 36);
            this.label4.TabIndex = 35;
            this.label4.Text = "Accounts";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(166)))), ((int)(((byte)(110)))));
            this.label5.Location = new System.Drawing.Point(247, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 33);
            this.label5.TabIndex = 36;
            this.label5.Text = "User:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CurrentUsernameSettings
            // 
            this.CurrentUsernameSettings.AutoSize = true;
            this.CurrentUsernameSettings.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.CurrentUsernameSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(166)))), ((int)(((byte)(110)))));
            this.CurrentUsernameSettings.Location = new System.Drawing.Point(347, 94);
            this.CurrentUsernameSettings.Name = "CurrentUsernameSettings";
            this.CurrentUsernameSettings.Size = new System.Drawing.Size(146, 33);
            this.CurrentUsernameSettings.TabIndex = 37;
            this.CurrentUsernameSettings.Text = "Username";
            this.CurrentUsernameSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Logout
            // 
            this.Logout.BorderRadius = 18;
            this.Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.Logout.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.Logout.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.Logout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.Logout.Location = new System.Drawing.Point(622, 370);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(79, 38);
            this.Logout.TabIndex = 43;
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.SettingsIndexPanel);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(769, 468);
            this.SettingsIndexPanel.ResumeLayout(false);
            this.SettingsIndexPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel SettingsIndexPanel;
        private Guna.UI2.WinForms.Guna2Button DeleteAccount;
        private Guna.UI2.WinForms.Guna2Button CreateAccount;
        private Guna.UI2.WinForms.Guna2Button ChangePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CurrentUsernameSettings;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Logout;
    }
}
