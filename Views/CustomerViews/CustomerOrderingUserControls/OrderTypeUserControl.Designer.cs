namespace Orange_POS.Views.CustomerViews.CustomerOrderingUserControls
{
    partial class OrderTypeUserControl
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
            this.DineInButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.TakeOutButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.LogoPictureBox1 = new System.Windows.Forms.PictureBox();
            this.DiningLocationLabel = new System.Windows.Forms.Label();
            this.DineinLabel = new System.Windows.Forms.Label();
            this.TakeoutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DineInButton
            // 
            this.DineInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.DineInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DineInButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DineInButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DineInButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DineInButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DineInButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.DineInButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DineInButton.ForeColor = System.Drawing.Color.White;
            this.DineInButton.ImageOffset = new System.Drawing.Point(0, 30);
            this.DineInButton.ImageSize = new System.Drawing.Size(200, 200);
            this.DineInButton.Location = new System.Drawing.Point(91, 333);
            this.DineInButton.Name = "DineInButton";
            this.DineInButton.Size = new System.Drawing.Size(230, 273);
            this.DineInButton.TabIndex = 0;
            this.DineInButton.Click += new System.EventHandler(this.DineInButton_Click);
            // 
            // TakeOutButton
            // 
            this.TakeOutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TakeOutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TakeOutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TakeOutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TakeOutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.TakeOutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TakeOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(251)))));
            this.TakeOutButton.ImageOffset = new System.Drawing.Point(0, 30);
            this.TakeOutButton.ImageSize = new System.Drawing.Size(200, 200);
            this.TakeOutButton.Location = new System.Drawing.Point(339, 333);
            this.TakeOutButton.Name = "TakeOutButton";
            this.TakeOutButton.Size = new System.Drawing.Size(230, 273);
            this.TakeOutButton.TabIndex = 1;
            this.TakeOutButton.Click += new System.EventHandler(this.TakeOutButton_Click);

            // 
            // LogoPictureBox1
            // 
            this.LogoPictureBox1.BackColor = System.Drawing.Color.White;
            this.LogoPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoPictureBox1.Location = new System.Drawing.Point(200, 0);
            this.LogoPictureBox1.Name = "LogoPictureBox1";
            this.LogoPictureBox1.Size = new System.Drawing.Size(264, 253);
            this.LogoPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox1.TabIndex = 7;
            this.LogoPictureBox1.TabStop = false;
            // 
            // DiningLocationLabel
            // 
            this.DiningLocationLabel.AutoSize = true;
            this.DiningLocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.DiningLocationLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiningLocationLabel.ForeColor = System.Drawing.Color.White;
            this.DiningLocationLabel.Location = new System.Drawing.Point(226, 276);
            this.DiningLocationLabel.Name = "DiningLocationLabel";
            this.DiningLocationLabel.Size = new System.Drawing.Size(214, 32);
            this.DiningLocationLabel.TabIndex = 8;
            this.DiningLocationLabel.Text = "Dining Location";
            // 
            // DineinLabel
            // 
            this.DineinLabel.AutoSize = true;
            this.DineinLabel.BackColor = System.Drawing.Color.White;
            this.DineinLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DineinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.DineinLabel.Location = new System.Drawing.Point(151, 353);
            this.DineinLabel.Name = "DineinLabel";
            this.DineinLabel.Size = new System.Drawing.Size(106, 33);
            this.DineinLabel.TabIndex = 9;
            this.DineinLabel.Text = "Dine-in";
            // 
            // TakeoutLabel
            // 
            this.TakeoutLabel.AutoSize = true;
            this.TakeoutLabel.BackColor = System.Drawing.Color.White;
            this.TakeoutLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakeoutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.TakeoutLabel.Location = new System.Drawing.Point(387, 353);
            this.TakeoutLabel.Name = "TakeoutLabel";
            this.TakeoutLabel.Size = new System.Drawing.Size(129, 33);
            this.TakeoutLabel.TabIndex = 10;
            this.TakeoutLabel.Text = "Take-out";
            // 
            // OrderTypeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.TakeoutLabel);
            this.Controls.Add(this.DineinLabel);
            this.Controls.Add(this.DiningLocationLabel);
            this.Controls.Add(this.LogoPictureBox1);
            this.Controls.Add(this.TakeOutButton);
            this.Controls.Add(this.DineInButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderTypeUserControl";
            this.Size = new System.Drawing.Size(680, 721);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton DineInButton;
        private Guna.UI2.WinForms.Guna2TileButton TakeOutButton;
        private System.Windows.Forms.PictureBox LogoPictureBox1;
        private System.Windows.Forms.Label DiningLocationLabel;
        private System.Windows.Forms.Label DineinLabel;
        private System.Windows.Forms.Label TakeoutLabel;
    }
}
