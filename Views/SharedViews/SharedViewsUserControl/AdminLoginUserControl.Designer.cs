namespace Orange_POS.Views.SharedViews.SharedViewsUserControl
{
    partial class AdminLoginUserControl
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
            this.BackButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.AdminPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AdminLoginButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.AdminUsernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BorderColor = System.Drawing.Color.Transparent;
            this.BackButton.BorderRadius = 20;
            this.BackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton.FillColor = System.Drawing.Color.Transparent;
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.BackButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.Location = new System.Drawing.Point(137, 325);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(91, 52);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // AdminPasswordTextBox
            // 
            this.AdminPasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AdminPasswordTextBox.BorderRadius = 20;
            this.AdminPasswordTextBox.BorderThickness = 2;
            this.AdminPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminPasswordTextBox.DefaultText = "";
            this.AdminPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AdminPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AdminPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminPasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.AdminPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AdminPasswordTextBox.Location = new System.Drawing.Point(55, 212);
            this.AdminPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdminPasswordTextBox.Name = "AdminPasswordTextBox";
            this.AdminPasswordTextBox.PasswordChar = '\0';
            this.AdminPasswordTextBox.PlaceholderText = "Password";
            this.AdminPasswordTextBox.SelectedText = "";
            this.AdminPasswordTextBox.Size = new System.Drawing.Size(256, 42);
            this.AdminPasswordTextBox.TabIndex = 13;
            this.AdminPasswordTextBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // AdminLoginButton
            // 
            this.AdminLoginButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AdminLoginButton.BorderRadius = 20;
            this.AdminLoginButton.BorderThickness = 2;
            this.AdminLoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AdminLoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AdminLoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AdminLoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AdminLoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AdminLoginButton.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.AdminLoginButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AdminLoginButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.AdminLoginButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AdminLoginButton.Location = new System.Drawing.Point(55, 280);
            this.AdminLoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.AdminLoginButton.Name = "AdminLoginButton";
            this.AdminLoginButton.Size = new System.Drawing.Size(256, 42);
            this.AdminLoginButton.TabIndex = 12;
            this.AdminLoginButton.Text = "Log in";
            this.AdminLoginButton.Click += new System.EventHandler(this.AdminLoginButton_Click_1);
            // 
            // AdminUsernameTextBox
            // 
            this.AdminUsernameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AdminUsernameTextBox.BorderRadius = 20;
            this.AdminUsernameTextBox.BorderThickness = 2;
            this.AdminUsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminUsernameTextBox.DefaultText = "";
            this.AdminUsernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AdminUsernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AdminUsernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminUsernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdminUsernameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.AdminUsernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminUsernameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AdminUsernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AdminUsernameTextBox.Location = new System.Drawing.Point(55, 162);
            this.AdminUsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdminUsernameTextBox.Name = "AdminUsernameTextBox";
            this.AdminUsernameTextBox.PasswordChar = '\0';
            this.AdminUsernameTextBox.PlaceholderText = "Username";
            this.AdminUsernameTextBox.SelectedText = "";
            this.AdminUsernameTextBox.Size = new System.Drawing.Size(256, 42);
            this.AdminUsernameTextBox.TabIndex = 11;
            this.AdminUsernameTextBox.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = false;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.LoginLabel.Location = new System.Drawing.Point(8, 70);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(243, 70);
            this.LoginLabel.TabIndex = 10;
            this.LoginLabel.Text = "Admin";
            this.LoginLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AdminLoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AdminPasswordTextBox);
            this.Controls.Add(this.AdminLoginButton);
            this.Controls.Add(this.AdminUsernameTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminLoginUserControl";
            this.Size = new System.Drawing.Size(368, 468);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton BackButton;
        private Guna.UI2.WinForms.Guna2TextBox AdminPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TileButton AdminLoginButton;
        private Guna.UI2.WinForms.Guna2TextBox AdminUsernameTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel LoginLabel;
    }
}
