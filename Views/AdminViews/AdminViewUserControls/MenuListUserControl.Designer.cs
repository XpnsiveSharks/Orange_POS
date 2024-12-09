namespace Orange_POS.Views.AdminViews.AdminViewUserControls
{
    partial class MenuListUserControl
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
            this.AddMenuButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.EditMenuButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.DeleteMenuButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.ProductSearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.MenuListFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // AddMenuButton
            // 
            this.AddMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.AddMenuButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddMenuButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddMenuButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddMenuButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddMenuButton.FillColor = System.Drawing.Color.Transparent;
            this.AddMenuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddMenuButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddMenuButton.Image = global::Orange_POS.Properties.Resources._26;
            this.AddMenuButton.Location = new System.Drawing.Point(31, 23);
            this.AddMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddMenuButton.Name = "AddMenuButton";
            this.AddMenuButton.Size = new System.Drawing.Size(35, 32);
            this.AddMenuButton.TabIndex = 12;
            this.AddMenuButton.Click += new System.EventHandler(this.AddMenuButton_Click);
            // 
            // EditMenuButton
            // 
            this.EditMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.EditMenuButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditMenuButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditMenuButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditMenuButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditMenuButton.FillColor = System.Drawing.Color.Transparent;
            this.EditMenuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditMenuButton.ForeColor = System.Drawing.Color.Transparent;
            this.EditMenuButton.Image = global::Orange_POS.Properties.Resources._27;
            this.EditMenuButton.Location = new System.Drawing.Point(70, 24);
            this.EditMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditMenuButton.Name = "EditMenuButton";
            this.EditMenuButton.Size = new System.Drawing.Size(34, 30);
            this.EditMenuButton.TabIndex = 18;
            this.EditMenuButton.Click += new System.EventHandler(this.EditMenuButton_Click);
            // 
            // DeleteMenuButton
            // 
            this.DeleteMenuButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteMenuButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteMenuButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteMenuButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteMenuButton.FillColor = System.Drawing.Color.Transparent;
            this.DeleteMenuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteMenuButton.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteMenuButton.Image = global::Orange_POS.Properties.Resources.Kiosk_Logo__4_;
            this.DeleteMenuButton.Location = new System.Drawing.Point(108, 22);
            this.DeleteMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteMenuButton.Name = "DeleteMenuButton";
            this.DeleteMenuButton.Size = new System.Drawing.Size(31, 33);
            this.DeleteMenuButton.TabIndex = 17;
            // 
            // ProductSearchTextBox
            // 
            this.ProductSearchTextBox.BorderRadius = 20;
            this.ProductSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductSearchTextBox.DefaultText = "";
            this.ProductSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProductSearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductSearchTextBox.Location = new System.Drawing.Point(529, 22);
            this.ProductSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductSearchTextBox.Name = "ProductSearchTextBox";
            this.ProductSearchTextBox.PasswordChar = '\0';
            this.ProductSearchTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.ProductSearchTextBox.PlaceholderText = "Search";
            this.ProductSearchTextBox.SelectedText = "";
            this.ProductSearchTextBox.Size = new System.Drawing.Size(213, 32);
            this.ProductSearchTextBox.TabIndex = 15;
            // 
            // MenuListFlowLayoutPanel
            // 
            this.MenuListFlowLayoutPanel.AutoScroll = true;
            this.MenuListFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.MenuListFlowLayoutPanel.Location = new System.Drawing.Point(25, 61);
            this.MenuListFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MenuListFlowLayoutPanel.Name = "MenuListFlowLayoutPanel";
            this.MenuListFlowLayoutPanel.Size = new System.Drawing.Size(717, 386);
            this.MenuListFlowLayoutPanel.TabIndex = 16;
            // 
            // MenuListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.Controls.Add(this.MenuListFlowLayoutPanel);
            this.Controls.Add(this.ProductSearchTextBox);
            this.Controls.Add(this.DeleteMenuButton);
            this.Controls.Add(this.EditMenuButton);
            this.Controls.Add(this.AddMenuButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuListUserControl";
            this.Size = new System.Drawing.Size(769, 468);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TileButton AddMenuButton;
        private Guna.UI2.WinForms.Guna2TileButton EditMenuButton;
        private Guna.UI2.WinForms.Guna2TileButton DeleteMenuButton;
        private Guna.UI2.WinForms.Guna2TextBox ProductSearchTextBox;
        private System.Windows.Forms.FlowLayoutPanel MenuListFlowLayoutPanel;
    }
}
