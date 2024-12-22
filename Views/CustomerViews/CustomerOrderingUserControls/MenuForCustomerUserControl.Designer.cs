namespace Orange_POS.Views.CustomerViews.CustomerOrderingUserControls
{
    partial class MenuForCustomerUserControl
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
            this.ProductPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.MenuCategoryLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ProductButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PriceLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ProductNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductPanel
            // 
            this.ProductPanel.BackColor = System.Drawing.Color.Transparent;
            this.ProductPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.ProductPanel.BorderRadius = 15;
            this.ProductPanel.BorderThickness = 2;
            this.ProductPanel.Controls.Add(this.MenuCategoryLabel);
            this.ProductPanel.Controls.Add(this.ProductButton);
            this.ProductPanel.Controls.Add(this.PriceLabel);
            this.ProductPanel.Controls.Add(this.ProductNameLabel);
            this.ProductPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.ProductPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.ProductPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.ProductPanel.Location = new System.Drawing.Point(23, 18);
            this.ProductPanel.Margin = new System.Windows.Forms.Padding(1);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(210, 250);
            this.ProductPanel.TabIndex = 0;
            // 
            // MenuCategoryLabel
            // 
            this.MenuCategoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.MenuCategoryLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MenuCategoryLabel.Location = new System.Drawing.Point(18, 217);
            this.MenuCategoryLabel.Margin = new System.Windows.Forms.Padding(1);
            this.MenuCategoryLabel.Name = "MenuCategoryLabel";
            this.MenuCategoryLabel.Size = new System.Drawing.Size(103, 19);
            this.MenuCategoryLabel.TabIndex = 4;
            this.MenuCategoryLabel.Text = "Menu Category";
            // 
            // ProductButton
            // 
            this.ProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.ProductButton.BorderRadius = 15;
            this.ProductButton.ImageRotate = 0F;
            this.ProductButton.Location = new System.Drawing.Point(18, 18);
            this.ProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(170, 140);
            this.ProductButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductButton.TabIndex = 3;
            this.ProductButton.TabStop = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriceLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PriceLabel.Location = new System.Drawing.Point(18, 194);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(1);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(56, 19);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "₱ 100.00";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductNameLabel.Enabled = false;
            this.ProductNameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProductNameLabel.Location = new System.Drawing.Point(18, 170);
            this.ProductNameLabel.Margin = new System.Windows.Forms.Padding(1);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(108, 20);
            this.ProductNameLabel.TabIndex = 1;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // MenuForCustomerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ProductPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MenuForCustomerUserControl";
            this.Size = new System.Drawing.Size(245, 285);
            this.ProductPanel.ResumeLayout(false);
            this.ProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel ProductPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel ProductNameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel PriceLabel;
        private Guna.UI2.WinForms.Guna2PictureBox ProductButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel MenuCategoryLabel;
    }
}
