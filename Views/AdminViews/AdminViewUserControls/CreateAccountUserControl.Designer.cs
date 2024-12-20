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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountUserControl));
            this.CreateUserRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CreatePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.CreateUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.BackButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.CreateAccountButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.FirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.MiddleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.LastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.ContactNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ShowConfirmPassword_ = new System.Windows.Forms.Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ShowPassword_ = new System.Windows.Forms.Button();
            this.HidePassword_ = new System.Windows.Forms.Button();
            this.ConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.HideConfirmPassword_ = new System.Windows.Forms.Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateUserRole
            // 
            this.CreateUserRole.BackColor = System.Drawing.Color.Transparent;
            this.CreateUserRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateUserRole.BorderRadius = 10;
            this.CreateUserRole.BorderThickness = 2;
            this.CreateUserRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CreateUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreateUserRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreateUserRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreateUserRole.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CreateUserRole.ItemHeight = 30;
            this.CreateUserRole.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.CreateUserRole.Location = new System.Drawing.Point(559, 8);
            this.CreateUserRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateUserRole.Name = "CreateUserRole";
            this.CreateUserRole.Size = new System.Drawing.Size(149, 36);
            this.CreateUserRole.TabIndex = 36;
            // 
            // CreatePassword
            // 
            this.CreatePassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreatePassword.BorderRadius = 10;
            this.CreatePassword.BorderThickness = 2;
            this.CreatePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreatePassword.DefaultText = "";
            this.CreatePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CreatePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CreatePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreatePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreatePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CreatePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreatePassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CreatePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreatePassword.Location = new System.Drawing.Point(229, 289);
            this.CreatePassword.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CreatePassword.Name = "CreatePassword";
            this.CreatePassword.PasswordChar = '●';
            this.CreatePassword.PlaceholderText = "Password";
            this.CreatePassword.SelectedText = "";
            this.CreatePassword.Size = new System.Drawing.Size(449, 29);
            this.CreatePassword.TabIndex = 37;
            this.CreatePassword.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // CreateUsername
            // 
            this.CreateUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateUsername.BorderRadius = 10;
            this.CreateUsername.BorderThickness = 2;
            this.CreateUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreateUsername.DefaultText = "";
            this.CreateUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CreateUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CreateUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreateUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreateUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CreateUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreateUsername.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CreateUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateUsername.Location = new System.Drawing.Point(229, 245);
            this.CreateUsername.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CreateUsername.Name = "CreateUsername";
            this.CreateUsername.PasswordChar = '\0';
            this.CreateUsername.PlaceholderText = "Username";
            this.CreateUsername.SelectedText = "";
            this.CreateUsername.Size = new System.Drawing.Size(449, 29);
            this.CreateUsername.TabIndex = 38;
            this.CreateUsername.TextOffset = new System.Drawing.Point(8, 0);
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
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.BackButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.Location = new System.Drawing.Point(393, 388);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(132, 34);
            this.BackButton.TabIndex = 40;
            this.BackButton.Text = "back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateAccountButton.BorderRadius = 16;
            this.CreateAccountButton.BorderThickness = 2;
            this.CreateAccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateAccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateAccountButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateAccountButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.CreateAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CreateAccountButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateAccountButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.CreateAccountButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CreateAccountButton.Location = new System.Drawing.Point(541, 388);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(167, 34);
            this.CreateAccountButton.TabIndex = 39;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.Controls.Add(this.FirstName);
            this.guna2Panel1.Controls.Add(this.MiddleName);
            this.guna2Panel1.Controls.Add(this.LastName);
            this.guna2Panel1.Controls.Add(this.ContactNumber);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2Panel1.Controls.Add(this.Email);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel1.Controls.Add(this.ShowConfirmPassword_);
            this.guna2Panel1.Controls.Add(this.BackButton);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.CreateAccountButton);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.CreateUsername);
            this.guna2Panel1.Controls.Add(this.ShowPassword_);
            this.guna2Panel1.Controls.Add(this.HidePassword_);
            this.guna2Panel1.Controls.Add(this.ConfirmPassword);
            this.guna2Panel1.Controls.Add(this.HideConfirmPassword_);
            this.guna2Panel1.Controls.Add(this.CreatePassword);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.guna2Panel1.Location = new System.Drawing.Point(16, 14);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(732, 437);
            this.guna2Panel1.TabIndex = 42;
            // 
            // FirstName
            // 
            this.FirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.FirstName.BorderRadius = 10;
            this.FirstName.BorderThickness = 2;
            this.FirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstName.DefaultText = "";
            this.FirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.FirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.FirstName.Location = new System.Drawing.Point(56, 104);
            this.FirstName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.FirstName.Name = "FirstName";
            this.FirstName.PasswordChar = '\0';
            this.FirstName.PlaceholderText = "FirstName";
            this.FirstName.SelectedText = "";
            this.FirstName.Size = new System.Drawing.Size(196, 29);
            this.FirstName.TabIndex = 71;
            this.FirstName.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // MiddleName
            // 
            this.MiddleName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.MiddleName.BorderRadius = 10;
            this.MiddleName.BorderThickness = 2;
            this.MiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MiddleName.DefaultText = "";
            this.MiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MiddleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MiddleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MiddleName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.MiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MiddleName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.MiddleName.Location = new System.Drawing.Point(272, 104);
            this.MiddleName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.PasswordChar = '\0';
            this.MiddleName.PlaceholderText = "MiddleName";
            this.MiddleName.SelectedText = "";
            this.MiddleName.Size = new System.Drawing.Size(196, 29);
            this.MiddleName.TabIndex = 70;
            this.MiddleName.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // LastName
            // 
            this.LastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.LastName.BorderRadius = 10;
            this.LastName.BorderThickness = 2;
            this.LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastName.DefaultText = "";
            this.LastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.LastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.LastName.Location = new System.Drawing.Point(482, 104);
            this.LastName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.LastName.Name = "LastName";
            this.LastName.PasswordChar = '\0';
            this.LastName.PlaceholderText = "LastName";
            this.LastName.SelectedText = "";
            this.LastName.Size = new System.Drawing.Size(196, 29);
            this.LastName.TabIndex = 69;
            this.LastName.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // ContactNumber
            // 
            this.ContactNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.ContactNumber.BorderRadius = 10;
            this.ContactNumber.BorderThickness = 2;
            this.ContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ContactNumber.DefaultText = "";
            this.ContactNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ContactNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ContactNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ContactNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ContactNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.ContactNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ContactNumber.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ContactNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContactNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.ContactNumber.Location = new System.Drawing.Point(229, 202);
            this.ContactNumber.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.PasswordChar = '\0';
            this.ContactNumber.PlaceholderText = "ContactNumber";
            this.ContactNumber.SelectedText = "";
            this.ContactNumber.Size = new System.Drawing.Size(449, 29);
            this.ContactNumber.TabIndex = 67;
            this.ContactNumber.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(35, 202);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(117, 24);
            this.guna2HtmlLabel8.TabIndex = 66;
            this.guna2HtmlLabel8.Text = "Contact No:";
            // 
            // Email
            // 
            this.Email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.Email.BorderRadius = 10;
            this.Email.BorderThickness = 2;
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.DefaultText = "";
            this.Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.Email.Location = new System.Drawing.Point(229, 151);
            this.Email.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.PlaceholderText = "Email";
            this.Email.SelectedText = "";
            this.Email.Size = new System.Drawing.Size(449, 29);
            this.Email.TabIndex = 65;
            this.Email.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(35, 154);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(54, 24);
            this.guna2HtmlLabel7.TabIndex = 64;
            this.guna2HtmlLabel7.Text = "Email:";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(35, 71);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(91, 24);
            this.guna2HtmlLabel6.TabIndex = 62;
            this.guna2HtmlLabel6.Text = "Full Name";
            // 
            // ShowConfirmPassword_
            // 
            this.ShowConfirmPassword_.FlatAppearance.BorderSize = 0;
            this.ShowConfirmPassword_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowConfirmPassword_.Image = ((System.Drawing.Image)(resources.GetObject("ShowConfirmPassword_.Image")));
            this.ShowConfirmPassword_.Location = new System.Drawing.Point(625, 338);
            this.ShowConfirmPassword_.Name = "ShowConfirmPassword_";
            this.ShowConfirmPassword_.Size = new System.Drawing.Size(40, 32);
            this.ShowConfirmPassword_.TabIndex = 60;
            this.ShowConfirmPassword_.TabStop = false;
            this.ShowConfirmPassword_.UseVisualStyleBackColor = true;
            this.ShowConfirmPassword_.Click += new System.EventHandler(this.ShowConfirmPassword__Click_1);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(35, 343);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(169, 24);
            this.guna2HtmlLabel4.TabIndex = 46;
            this.guna2HtmlLabel4.Text = "Confirm Password:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(35, 291);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(93, 24);
            this.guna2HtmlLabel3.TabIndex = 45;
            this.guna2HtmlLabel3.Text = "Password:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(35, 243);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(99, 24);
            this.guna2HtmlLabel1.TabIndex = 43;
            this.guna2HtmlLabel1.Text = "Username:";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 25;
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel2.Controls.Add(this.CreateUserRole);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
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
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(23, 8);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(212, 34);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Create Account";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(467, 14);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(71, 23);
            this.guna2HtmlLabel5.TabIndex = 48;
            this.guna2HtmlLabel5.Text = "User role:";
            // 
            // ShowPassword_
            // 
            this.ShowPassword_.FlatAppearance.BorderSize = 0;
            this.ShowPassword_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPassword_.Image = ((System.Drawing.Image)(resources.GetObject("ShowPassword_.Image")));
            this.ShowPassword_.Location = new System.Drawing.Point(626, 286);
            this.ShowPassword_.Name = "ShowPassword_";
            this.ShowPassword_.Size = new System.Drawing.Size(40, 32);
            this.ShowPassword_.TabIndex = 59;
            this.ShowPassword_.TabStop = false;
            this.ShowPassword_.UseVisualStyleBackColor = true;
            this.ShowPassword_.Click += new System.EventHandler(this.ShowPassword__Click);
            // 
            // HidePassword_
            // 
            this.HidePassword_.FlatAppearance.BorderSize = 0;
            this.HidePassword_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HidePassword_.Image = ((System.Drawing.Image)(resources.GetObject("HidePassword_.Image")));
            this.HidePassword_.Location = new System.Drawing.Point(626, 286);
            this.HidePassword_.Name = "HidePassword_";
            this.HidePassword_.Size = new System.Drawing.Size(40, 32);
            this.HidePassword_.TabIndex = 58;
            this.HidePassword_.UseVisualStyleBackColor = true;
            this.HidePassword_.Click += new System.EventHandler(this.HidePassword__Click);
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.ConfirmPassword.BorderRadius = 10;
            this.ConfirmPassword.BorderThickness = 2;
            this.ConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmPassword.DefaultText = "";
            this.ConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.ConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.ConfirmPassword.Location = new System.Drawing.Point(229, 338);
            this.ConfirmPassword.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '●';
            this.ConfirmPassword.PlaceholderText = "Confirm Password";
            this.ConfirmPassword.SelectedText = "";
            this.ConfirmPassword.Size = new System.Drawing.Size(449, 29);
            this.ConfirmPassword.TabIndex = 44;
            this.ConfirmPassword.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // HideConfirmPassword_
            // 
            this.HideConfirmPassword_.FlatAppearance.BorderSize = 0;
            this.HideConfirmPassword_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideConfirmPassword_.Image = ((System.Drawing.Image)(resources.GetObject("HideConfirmPassword_.Image")));
            this.HideConfirmPassword_.Location = new System.Drawing.Point(625, 335);
            this.HideConfirmPassword_.Name = "HideConfirmPassword_";
            this.HideConfirmPassword_.Size = new System.Drawing.Size(40, 32);
            this.HideConfirmPassword_.TabIndex = 61;
            this.HideConfirmPassword_.UseVisualStyleBackColor = true;
            this.HideConfirmPassword_.Click += new System.EventHandler(this.HideConfirmPassword__Click_1);
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
            this.Size = new System.Drawing.Size(762, 482);
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
        private Guna.UI2.WinForms.Guna2TileButton BackButton;
        private Guna.UI2.WinForms.Guna2TileButton CreateAccountButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.Button HidePassword_;
        private System.Windows.Forms.Button ShowPassword_;
        private System.Windows.Forms.Button HideConfirmPassword_;
        private System.Windows.Forms.Button ShowConfirmPassword_;
        private Guna.UI2.WinForms.Guna2TextBox ContactNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2TextBox Email;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox LastName;
        private Guna.UI2.WinForms.Guna2TextBox FirstName;
        private Guna.UI2.WinForms.Guna2TextBox MiddleName;
    }
}
