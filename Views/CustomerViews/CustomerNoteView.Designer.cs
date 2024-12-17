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
            this.NoteTextBox = new System.Windows.Forms.RichTextBox();
            this.SubmitNoteButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(12, 12);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(439, 185);
            this.NoteTextBox.TabIndex = 1;
            this.NoteTextBox.Text = "Add note here";
            // 
            // SubmitNoteButton
            // 
            this.SubmitNoteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitNoteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitNoteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitNoteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitNoteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubmitNoteButton.ForeColor = System.Drawing.Color.White;
            this.SubmitNoteButton.Location = new System.Drawing.Point(352, 203);
            this.SubmitNoteButton.Name = "SubmitNoteButton";
            this.SubmitNoteButton.Size = new System.Drawing.Size(99, 33);
            this.SubmitNoteButton.TabIndex = 2;
            this.SubmitNoteButton.Text = "Add note";
            this.SubmitNoteButton.Click += new System.EventHandler(this.SubmitNoteButton_Click);
            // 
            // CustomerNoteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 247);
            this.Controls.Add(this.SubmitNoteButton);
            this.Controls.Add(this.NoteTextBox);
            this.Name = "CustomerNoteView";
            this.Text = "CustomerNoteView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox NoteTextBox;
        private Guna.UI2.WinForms.Guna2Button SubmitNoteButton;
    }
}