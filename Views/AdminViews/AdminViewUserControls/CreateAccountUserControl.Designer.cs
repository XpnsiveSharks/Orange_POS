namespace Orange_POS.Views.AdminViews.AdminViewUserControls
{
    partial class CreateAccountUserControl
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
            this.CreateUserRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CreatePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.CreateUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShowConfirmPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.BackButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.CreateAccountButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ShowPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateUserRole
            // 
            this.CreateUserRole.BackColor = System.Drawing.Color.Transparent;
            this.CreateUserRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CreateUserRole.BorderRadius = 16;
            this.CreateUserRole.BorderThickness = 2;
            this.CreateUserRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CreateUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreateUserRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateUserRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateUserRole.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CreateUserRole.ItemHeight = 30;
            this.CreateUserRole.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.CreateUserRole.Location = new System.Drawing.Point(31, 110);
            this.CreateUserRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateUserRole.Name = "CreateUserRole";
            this.CreateUserRole.Size = new System.Drawing.Size(124, 36);
            this.CreateUserRole.TabIndex = 36;
            // 
            // CreatePassword
            // 
            this.CreatePassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CreatePassword.BorderRadius = 16;
            this.CreatePassword.BorderThickness = 2;
            this.CreatePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreatePassword.DefaultText = "";
            this.CreatePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CreatePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CreatePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreatePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreatePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CreatePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreatePassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CreatePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CreatePassword.Location = new System.Drawing.Point(213, 197);
            this.CreatePassword.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CreatePassword.Name = "CreatePassword";
            this.CreatePassword.PasswordChar = '●';
            this.CreatePassword.PlaceholderText = "Password";
            this.CreatePassword.SelectedText = "";
            this.CreatePassword.Size = new System.Drawing.Size(325, 36);
            this.CreatePassword.TabIndex = 37;
            this.CreatePassword.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // CreateUsername
            // 
            this.CreateUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CreateUsername.BorderRadius = 16;
            this.CreateUsername.BorderThickness = 2;
            this.CreateUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreateUsername.DefaultText = "";
            this.CreateUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CreateUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CreateUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreateUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreateUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CreateUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateUsername.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CreateUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CreateUsername.Location = new System.Drawing.Point(213, 110);
            this.CreateUsername.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CreateUsername.Name = "CreateUsername";
            this.CreateUsername.PasswordChar = '\0';
            this.CreateUsername.PlaceholderText = "Username";
            this.CreateUsername.SelectedText = "";
            this.CreateUsername.Size = new System.Drawing.Size(325, 36);
            this.CreateUsername.TabIndex = 38;
            this.CreateUsername.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // ShowConfirmPassword
            // 
            this.ShowConfirmPassword.AutoSize = true;
            this.ShowConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.ShowConfirmPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowConfirmPassword.CheckedState.BorderRadius = 0;
            this.ShowConfirmPassword.CheckedState.BorderThickness = 0;
            this.ShowConfirmPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowConfirmPassword.CheckMarkColor = System.Drawing.Color.Black;
            this.ShowConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ShowConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowConfirmPassword.Location = new System.Drawing.Point(568, 297);
            this.ShowConfirmPassword.Name = "ShowConfirmPassword";
            this.ShowConfirmPassword.Size = new System.Drawing.Size(102, 17);
            this.ShowConfirmPassword.TabIndex = 41;
            this.ShowConfirmPassword.Text = "Show Password";
            this.ShowConfirmPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowConfirmPassword.UncheckedState.BorderRadius = 0;
            this.ShowConfirmPassword.UncheckedState.BorderThickness = 0;
            this.ShowConfirmPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowConfirmPassword.UseVisualStyleBackColor = false;
            this.ShowConfirmPassword.CheckedChanged += new System.EventHandler(this.ShowConfirmPassword_CheckedChanged);
            // 
            // BackButton
            // 
            this.BackButton.BorderColor = System.Drawing.Color.Transparent;
            this.BackButton.BorderRadius = 16;
            this.BackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton.FillColor = System.Drawing.Color.Transparent;
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.BackButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.Location = new System.Drawing.Point(325, 391);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 30);
            this.BackButton.TabIndex = 40;
            this.BackButton.Text = "back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CreateAccountButton.BorderRadius = 16;
            this.CreateAccountButton.BorderThickness = 2;
            this.CreateAccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateAccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateAccountButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CreateAccountButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.CreateAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CreateAccountButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CreateAccountButton.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.CreateAccountButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CreateAccountButton.Location = new System.Drawing.Point(260, 349);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(228, 36);
            this.CreateAccountButton.TabIndex = 39;
            this.CreateAccountButton.Text = "Create";
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel1.Controls.Add(this.CreatePassword);
            this.guna2Panel1.Controls.Add(this.ShowPassword);
            this.guna2Panel1.Controls.Add(this.BackButton);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.CreateAccountButton);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.ConfirmPassword);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.CreateUsername);
            this.guna2Panel1.Controls.Add(this.ShowConfirmPassword);
            this.guna2Panel1.Controls.Add(this.CreateUserRole);
            this.guna2Panel1.FillColor = System.Drawing.Color.AntiqueWhite;
            this.guna2Panel1.Location = new System.Drawing.Point(16, 14);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(732, 437);
            this.guna2Panel1.TabIndex = 42;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(31, 77);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(83, 24);
            this.guna2HtmlLabel5.TabIndex = 48;
            this.guna2HtmlLabel5.Text = "User role:";
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.ShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowPassword.CheckedState.BorderRadius = 0;
            this.ShowPassword.CheckedState.BorderThickness = 0;
            this.ShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowPassword.CheckMarkColor = System.Drawing.Color.Black;
            this.ShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowPassword.Location = new System.Drawing.Point(568, 208);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.ShowPassword.TabIndex = 47;
            this.ShowPassword.Text = "Show Password";
            this.ShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowPassword.UncheckedState.BorderRadius = 0;
            this.ShowPassword.UncheckedState.BorderThickness = 0;
            this.ShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowPassword.UseVisualStyleBackColor = false;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(213, 252);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(169, 24);
            this.guna2HtmlLabel4.TabIndex = 46;
            this.guna2HtmlLabel4.Text = "Confirm Password:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(213, 166);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(93, 24);
            this.guna2HtmlLabel3.TabIndex = 45;
            this.guna2HtmlLabel3.Text = "Password:";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ConfirmPassword.BorderRadius = 16;
            this.ConfirmPassword.BorderThickness = 2;
            this.ConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmPassword.DefaultText = "";
            this.ConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.ConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.ConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ConfirmPassword.Location = new System.Drawing.Point(213, 285);
            this.ConfirmPassword.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '●';
            this.ConfirmPassword.PlaceholderText = "Confirm Password";
            this.ConfirmPassword.SelectedText = "";
            this.ConfirmPassword.Size = new System.Drawing.Size(325, 36);
            this.ConfirmPassword.TabIndex = 44;
            this.ConfirmPassword.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(213, 77);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(99, 24);
            this.guna2HtmlLabel1.TabIndex = 43;
            this.guna2HtmlLabel1.Text = "Username:";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 25;
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(732, 54);
            this.guna2Panel2.TabIndex = 42;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(23, 10);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(212, 34);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Create Account";
            // 
            // CreateAccountUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateAccountUserControl";
            this.Size = new System.Drawing.Size(782, 473);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox CreateUserRole;
        private Guna.UI2.WinForms.Guna2TextBox CreatePassword;
        private Guna.UI2.WinForms.Guna2TextBox CreateUsername;
        private Guna.UI2.WinForms.Guna2CheckBox ShowConfirmPassword;
        private Guna.UI2.WinForms.Guna2TileButton BackButton;
        private Guna.UI2.WinForms.Guna2TileButton CreateAccountButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CheckBox ShowPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}
