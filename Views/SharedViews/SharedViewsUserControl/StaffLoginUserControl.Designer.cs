namespace Orange_POS.Views.SharedViews.SharedViewsUserControl
{
    partial class StaffLoginUserControl
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
            this.StaffPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.StaffLoginButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.StaffUsernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(91, 52);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // StaffPasswordTextBox
            // 
            this.StaffPasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.StaffPasswordTextBox.BorderRadius = 20;
            this.StaffPasswordTextBox.BorderThickness = 2;
            this.StaffPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffPasswordTextBox.DefaultText = "";
            this.StaffPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StaffPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StaffPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffPasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.StaffPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StaffPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.StaffPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.StaffPasswordTextBox.Location = new System.Drawing.Point(55, 212);
            this.StaffPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StaffPasswordTextBox.Name = "StaffPasswordTextBox";
            this.StaffPasswordTextBox.PasswordChar = '\0';
            this.StaffPasswordTextBox.PlaceholderText = "Password";
            this.StaffPasswordTextBox.SelectedText = "";
            this.StaffPasswordTextBox.Size = new System.Drawing.Size(256, 42);
            this.StaffPasswordTextBox.TabIndex = 8;
            this.StaffPasswordTextBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // StaffLoginButton
            // 
            this.StaffLoginButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.StaffLoginButton.BorderRadius = 20;
            this.StaffLoginButton.BorderThickness = 2;
            this.StaffLoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StaffLoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StaffLoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StaffLoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StaffLoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.StaffLoginButton.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffLoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.StaffLoginButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.StaffLoginButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.StaffLoginButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.StaffLoginButton.Location = new System.Drawing.Point(55, 280);
            this.StaffLoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StaffLoginButton.Name = "StaffLoginButton";
            this.StaffLoginButton.Size = new System.Drawing.Size(256, 42);
            this.StaffLoginButton.TabIndex = 7;
            this.StaffLoginButton.Text = "Log in";
            // 
            // StaffUsernameTextBox
            // 
            this.StaffUsernameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.StaffUsernameTextBox.BorderRadius = 20;
            this.StaffUsernameTextBox.BorderThickness = 2;
            this.StaffUsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffUsernameTextBox.DefaultText = "";
            this.StaffUsernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StaffUsernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StaffUsernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffUsernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StaffUsernameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.StaffUsernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StaffUsernameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.StaffUsernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.StaffUsernameTextBox.Location = new System.Drawing.Point(55, 162);
            this.StaffUsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StaffUsernameTextBox.Name = "StaffUsernameTextBox";
            this.StaffUsernameTextBox.PasswordChar = '\0';
            this.StaffUsernameTextBox.PlaceholderText = "Username";
            this.StaffUsernameTextBox.SelectedText = "";
            this.StaffUsernameTextBox.Size = new System.Drawing.Size(256, 42);
            this.StaffUsernameTextBox.TabIndex = 6;
            this.StaffUsernameTextBox.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = false;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.LoginLabel.Location = new System.Drawing.Point(83, 77);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(191, 80);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Staff";
            this.LoginLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaffLoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.StaffPasswordTextBox);
            this.Controls.Add(this.StaffLoginButton);
            this.Controls.Add(this.StaffUsernameTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StaffLoginUserControl";
            this.Size = new System.Drawing.Size(368, 468);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton BackButton;
        private Guna.UI2.WinForms.Guna2TextBox StaffPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TileButton StaffLoginButton;
        private Guna.UI2.WinForms.Guna2TextBox StaffUsernameTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel LoginLabel;
    }
}
