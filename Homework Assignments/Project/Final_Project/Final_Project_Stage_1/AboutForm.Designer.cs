namespace Final_Project_Stage_1
{
    partial class AboutForm
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
            this.closeFormButton = new System.Windows.Forms.Button();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeFormButton
            // 
            this.closeFormButton.Location = new System.Drawing.Point(200, 123);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(104, 23);
            this.closeFormButton.TabIndex = 0;
            this.closeFormButton.Text = "Back to Game";
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.closeFormButton_Click);
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTextBox.Location = new System.Drawing.Point(12, 12);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(292, 105);
            this.aboutTextBox.TabIndex = 1;
            this.aboutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 155);
            this.Controls.Add(this.aboutTextBox);
            this.Controls.Add(this.closeFormButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About the Game";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeFormButton;
        private System.Windows.Forms.TextBox aboutTextBox;
    }
}