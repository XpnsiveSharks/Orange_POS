namespace Orange_POS.Views.AdminViews.AdminViewUserControlContents
{
    partial class PendingOrderUserControl
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
            this.PendingOrderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.QuantityPendingOrder = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NamePendingOrder = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PendingOrderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PendingOrderPanel
            // 
            this.PendingOrderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.PendingOrderPanel.Controls.Add(this.guna2HtmlLabel1);
            this.PendingOrderPanel.Controls.Add(this.QuantityPendingOrder);
            this.PendingOrderPanel.Controls.Add(this.NamePendingOrder);
            this.PendingOrderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PendingOrderPanel.Location = new System.Drawing.Point(0, 0);
            this.PendingOrderPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PendingOrderPanel.Name = "PendingOrderPanel";
            this.PendingOrderPanel.Size = new System.Drawing.Size(227, 38);
            this.PendingOrderPanel.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(169, 8);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(19, 25);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "--";
            // 
            // QuantityPendingOrder
            // 
            this.QuantityPendingOrder.BackColor = System.Drawing.Color.Transparent;
            this.QuantityPendingOrder.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.QuantityPendingOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.QuantityPendingOrder.Location = new System.Drawing.Point(198, 8);
            this.QuantityPendingOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuantityPendingOrder.Name = "QuantityPendingOrder";
            this.QuantityPendingOrder.Size = new System.Drawing.Size(14, 25);
            this.QuantityPendingOrder.TabIndex = 1;
            this.QuantityPendingOrder.Text = "1";
            // 
            // NamePendingOrder
            // 
            this.NamePendingOrder.BackColor = System.Drawing.Color.Transparent;
            this.NamePendingOrder.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePendingOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.NamePendingOrder.Location = new System.Drawing.Point(7, 8);
            this.NamePendingOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NamePendingOrder.Name = "NamePendingOrder";
            this.NamePendingOrder.Size = new System.Drawing.Size(66, 25);
            this.NamePendingOrder.TabIndex = 0;
            this.NamePendingOrder.Text = "Meal 1";
            // 
            // PendingOrderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PendingOrderPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PendingOrderUserControl";
            this.Size = new System.Drawing.Size(227, 38);
            this.PendingOrderPanel.ResumeLayout(false);
            this.PendingOrderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PendingOrderPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel NamePendingOrder;
        private Guna.UI2.WinForms.Guna2HtmlLabel QuantityPendingOrder;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
