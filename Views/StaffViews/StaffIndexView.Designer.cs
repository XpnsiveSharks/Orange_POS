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
            this.SuspendLayout();
            // 
            // OrdersFlowLayoutPanel
            // 
            this.OrdersFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.OrdersFlowLayoutPanel.Name = "OrdersFlowLayoutPanel";
            this.OrdersFlowLayoutPanel.Size = new System.Drawing.Size(1031, 569);
            this.OrdersFlowLayoutPanel.TabIndex = 0;
            // 
            // StaffIndexView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 569);
            this.Controls.Add(this.OrdersFlowLayoutPanel);
            this.Name = "StaffIndexView";
            this.Text = "StaffIndexView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel OrdersFlowLayoutPanel;
    }
}