namespace Orange_POS.Views.AdminViews.AdminViewUserControls
{
    partial class OrderListUserControl
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
            this.OrderListFLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // OrderListFLayoutPanel
            // 
            this.OrderListFLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderListFLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.OrderListFLayoutPanel.Name = "OrderListFLayoutPanel";
            this.OrderListFLayoutPanel.Size = new System.Drawing.Size(1152, 720);
            this.OrderListFLayoutPanel.TabIndex = 0;
            // 
            // OrderListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrderListFLayoutPanel);
            this.Name = "OrderListUserControl";
            this.Size = new System.Drawing.Size(1152, 720);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel OrderListFLayoutPanel;
    }
}
