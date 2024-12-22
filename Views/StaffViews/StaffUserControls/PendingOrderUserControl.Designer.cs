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
            this.OrderNoteLabel = new System.Windows.Forms.Label();
            this.QuantityPendingOrder = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NamePendingOrder = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PendingOrderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PendingOrderPanel
            // 
            this.PendingOrderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.PendingOrderPanel.Controls.Add(this.OrderNoteLabel);
            this.PendingOrderPanel.Controls.Add(this.QuantityPendingOrder);
            this.PendingOrderPanel.Controls.Add(this.NamePendingOrder);
            this.PendingOrderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PendingOrderPanel.Location = new System.Drawing.Point(0, 0);
            this.PendingOrderPanel.Name = "PendingOrderPanel";
            this.PendingOrderPanel.Size = new System.Drawing.Size(294, 120);
            this.PendingOrderPanel.TabIndex = 0;
            // 
            // OrderNoteLabel
            // 
            this.OrderNoteLabel.AutoSize = true;
            this.OrderNoteLabel.Location = new System.Drawing.Point(6, 54);
            this.OrderNoteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderNoteLabel.MaximumSize = new System.Drawing.Size(150, 40);
            this.OrderNoteLabel.Name = "OrderNoteLabel";
            this.OrderNoteLabel.Size = new System.Drawing.Size(51, 20);
            this.OrderNoteLabel.TabIndex = 3;
            this.OrderNoteLabel.Text = "Note: ";
            // 
            // QuantityPendingOrder
            // 
            this.QuantityPendingOrder.BackColor = System.Drawing.Color.Transparent;
            this.QuantityPendingOrder.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.QuantityPendingOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QuantityPendingOrder.Location = new System.Drawing.Point(229, 12);
            this.QuantityPendingOrder.Name = "QuantityPendingOrder";
            this.QuantityPendingOrder.Size = new System.Drawing.Size(51, 36);
            this.QuantityPendingOrder.TabIndex = 1;
            this.QuantityPendingOrder.Text = "-- 1";
            // 
            // NamePendingOrder
            // 
            this.NamePendingOrder.BackColor = System.Drawing.Color.Transparent;
            this.NamePendingOrder.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePendingOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NamePendingOrder.Location = new System.Drawing.Point(10, 12);
            this.NamePendingOrder.Name = "NamePendingOrder";
            this.NamePendingOrder.Size = new System.Drawing.Size(95, 36);
            this.NamePendingOrder.TabIndex = 0;
            this.NamePendingOrder.Text = "Meal 1";
            // 
            // PendingOrderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PendingOrderPanel);
            this.Name = "PendingOrderUserControl";
            this.Size = new System.Drawing.Size(294, 120);
            this.PendingOrderPanel.ResumeLayout(false);
            this.PendingOrderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PendingOrderPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel NamePendingOrder;
        private Guna.UI2.WinForms.Guna2HtmlLabel QuantityPendingOrder;
        private System.Windows.Forms.Label OrderNoteLabel;
    }
}
