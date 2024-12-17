namespace Orange_POS.Views.CustomerViews.CustomerOrderingUserControls
{
    partial class PaymentMethodUserControl
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
            this.CashPaymentButton = new Guna.UI2.WinForms.Guna2Button();
            this.BackButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // CashPaymentButton
            // 
            this.CashPaymentButton.BorderRadius = 18;
            this.CashPaymentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CashPaymentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CashPaymentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CashPaymentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CashPaymentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CashPaymentButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CashPaymentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.CashPaymentButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CashPaymentButton.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.CashPaymentButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.CashPaymentButton.Location = new System.Drawing.Point(97, 294);
            this.CashPaymentButton.Name = "CashPaymentButton";
            this.CashPaymentButton.Size = new System.Drawing.Size(388, 114);
            this.CashPaymentButton.TabIndex = 1;
            this.CashPaymentButton.Text = "Cash (Pay at the counter)";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.BorderRadius = 18;
            this.BackButton.BorderThickness = 1;
            this.BackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton.FillColor = System.Drawing.Color.Transparent;
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.BackButton.Location = new System.Drawing.Point(128, 429);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(306, 45);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            // 
            // PaymentMethodUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CashPaymentButton);
            this.Name = "PaymentMethodUserControl";
            this.Size = new System.Drawing.Size(581, 707);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button CashPaymentButton;
        private Guna.UI2.WinForms.Guna2Button BackButton;
    }
}
