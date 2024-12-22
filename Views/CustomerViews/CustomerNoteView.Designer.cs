namespace Orange_POS.Views.CustomerViews
{
    partial class CustomerNoteView
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
            this.AddNoteButton = new Guna.UI2.WinForms.Guna2Button();
            this.BackButton = new Guna.UI2.WinForms.Guna2Button();
            this.orderListFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NoteTextBox = new System.Windows.Forms.RichTextBox();
            this.guna2Panel1.SuspendLayout();
            this.orderListFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.AddNoteButton);
            this.guna2Panel1.Controls.Add(this.BackButton);
            this.guna2Panel1.Controls.Add(this.orderListFlowLayoutPanel);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(625, 484);
            this.guna2Panel1.TabIndex = 0;
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.BackColor = System.Drawing.Color.Transparent;
            this.AddNoteButton.BorderColor = System.Drawing.Color.Transparent;
            this.AddNoteButton.BorderRadius = 20;
            this.AddNoteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddNoteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddNoteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddNoteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddNoteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(206)))));
            this.AddNoteButton.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.AddNoteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(16)))));
            this.AddNoteButton.Location = new System.Drawing.Point(412, 417);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.PressedColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddNoteButton.Size = new System.Drawing.Size(180, 45);
            this.AddNoteButton.TabIndex = 3;
            this.AddNoteButton.Text = "AddNote";
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
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
            this.BackButton.Location = new System.Drawing.Point(226, 417);
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
            this.orderListFlowLayoutPanel.Controls.Add(this.NoteTextBox);
            this.orderListFlowLayoutPanel.Location = new System.Drawing.Point(26, 34);
            this.orderListFlowLayoutPanel.Name = "orderListFlowLayoutPanel";
            this.orderListFlowLayoutPanel.Size = new System.Drawing.Size(566, 377);
            this.orderListFlowLayoutPanel.TabIndex = 1;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(3, 3);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(554, 360);
            this.NoteTextBox.TabIndex = 0;
            this.NoteTextBox.Text = "";
            // 
            // CustomerNoteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 475);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerNoteView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerMainFrameView";
            this.guna2Panel1.ResumeLayout(false);
            this.orderListFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel orderListFlowLayoutPanel;
        private Guna.UI2.WinForms.Guna2Button BackButton;
        private Guna.UI2.WinForms.Guna2Button AddNoteButton;
        private System.Windows.Forms.RichTextBox NoteTextBox;
    }
}