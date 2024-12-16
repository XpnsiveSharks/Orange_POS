namespace Orange_POS.Views.StaffViews
{
    partial class StaffIndexView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrdersFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.OrderCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersFlowLayoutPanel
            // 
            this.OrdersFlowLayoutPanel.AutoScroll = true;
            this.OrdersFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.OrdersFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrdersFlowLayoutPanel.Location = new System.Drawing.Point(0, 94);
            this.OrdersFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrdersFlowLayoutPanel.Name = "OrdersFlowLayoutPanel";
            this.OrdersFlowLayoutPanel.Size = new System.Drawing.Size(1280, 626);
            this.OrdersFlowLayoutPanel.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.OrderCount);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1280, 95);
            this.guna2Panel1.TabIndex = 1;
            // 
            // OrderCount
            // 
            this.OrderCount.AutoSize = false;
            this.OrderCount.BackColor = System.Drawing.Color.Transparent;
            this.OrderCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.OrderCount.Location = new System.Drawing.Point(25, 24);
            this.OrderCount.Name = "OrderCount";
            this.OrderCount.Size = new System.Drawing.Size(348, 62);
            this.OrderCount.TabIndex = 1;
            this.OrderCount.Text = "Pending orders: 2";
            // 
            // StaffIndexView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.OrdersFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StaffIndexView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffIndexView";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel OrdersFlowLayoutPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel OrderCount;
    }
}