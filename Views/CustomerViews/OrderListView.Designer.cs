namespace Orange_POS.Views.CustomerViews
{
    partial class OrderListView
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ProceedToPaymentButton = new Guna.UI2.WinForms.Guna2Button();
            this.BackButton = new Guna.UI2.WinForms.Guna2Button();
            this.orderListFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.TotalLabel);
            this.guna2Panel1.Controls.Add(this.ProceedToPaymentButton);
            this.guna2Panel1.Controls.Add(this.BackButton);
            this.guna2Panel1.Controls.Add(this.orderListFlowLayoutPanel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1280, 720);
            this.guna2Panel1.TabIndex = 0;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.Color.Snow;
            this.TotalLabel.Location = new System.Drawing.Point(38, 656);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(86, 30);
            this.TotalLabel.TabIndex = 4;
            this.TotalLabel.Text = "label1";
            // 
            // ProceedToPaymentButton
            // 
            this.ProceedToPaymentButton.BackColor = System.Drawing.Color.Transparent;
            this.ProceedToPaymentButton.BorderColor = System.Drawing.Color.Transparent;
            this.ProceedToPaymentButton.BorderRadius = 20;
            this.ProceedToPaymentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProceedToPaymentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProceedToPaymentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProceedToPaymentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProceedToPaymentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.ProceedToPaymentButton.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.ProceedToPaymentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.ProceedToPaymentButton.Location = new System.Drawing.Point(1067, 641);
            this.ProceedToPaymentButton.Name = "ProceedToPaymentButton";
            this.ProceedToPaymentButton.PressedColor = System.Drawing.SystemColors.AppWorkspace;
            this.ProceedToPaymentButton.Size = new System.Drawing.Size(180, 45);
            this.ProceedToPaymentButton.TabIndex = 3;
            this.ProceedToPaymentButton.Text = "Checkout";
            this.ProceedToPaymentButton.Click += new System.EventHandler(this.ProceedToPaymentButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BorderRadius = 20;
            this.BackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.Location = new System.Drawing.Point(881, 641);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(180, 45);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // orderListFlowLayoutPanel
            // 
            this.orderListFlowLayoutPanel.AutoScroll = true;
            this.orderListFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.orderListFlowLayoutPanel.Location = new System.Drawing.Point(26, 34);
            this.orderListFlowLayoutPanel.Name = "orderListFlowLayoutPanel";
            this.orderListFlowLayoutPanel.Size = new System.Drawing.Size(1221, 591);
            this.orderListFlowLayoutPanel.TabIndex = 1;
            // 
            // OrderListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerMainFrameView";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel orderListFlowLayoutPanel;
        private Guna.UI2.WinForms.Guna2Button BackButton;
        private Guna.UI2.WinForms.Guna2Button ProceedToPaymentButton;
        private System.Windows.Forms.Label TotalLabel;
    }
}