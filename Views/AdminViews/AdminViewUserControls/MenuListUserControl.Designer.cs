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
            this.ProductSearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.MenuListFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenuButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Image = global::Orange_POS.Properties.Resources._272;
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.UpdateToolStripMenuItem.Text = "Update";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::Orange_POS.Properties.Resources._28;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
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
            // MenuListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.Controls.Add(this.MenuListFlowLayoutPanel);
            this.Controls.Add(this.ProductSearchTextBox);
            this.Controls.Add(this.AddMenuButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuListUserControl";
            this.Size = new System.Drawing.Size(769, 468);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TileButton AddMenuButton;
        private Guna.UI2.WinForms.Guna2TextBox ProductSearchTextBox;
        private System.Windows.Forms.FlowLayoutPanel MenuListFlowLayoutPanel;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
    }
}
