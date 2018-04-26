namespace CS3020HW2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.aboutFormCloseButton = new System.Windows.Forms.Button();
            this.highScoresTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTextBox.Location = new System.Drawing.Point(13, 13);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.Size = new System.Drawing.Size(502, 214);
            this.aboutTextBox.TabIndex = 0;
            this.aboutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aboutFormCloseButton
            // 
            this.aboutFormCloseButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutFormCloseButton.Location = new System.Drawing.Point(455, 540);
            this.aboutFormCloseButton.Name = "aboutFormCloseButton";
            this.aboutFormCloseButton.Size = new System.Drawing.Size(60, 29);
            this.aboutFormCloseButton.TabIndex = 1;
            this.aboutFormCloseButton.Text = "Close";
            this.aboutFormCloseButton.UseVisualStyleBackColor = true;
            this.aboutFormCloseButton.Click += new System.EventHandler(this.OnAboutFormCloseButton_Click);
            // 
            // highScoresTextBox
            // 
            this.highScoresTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.highScoresTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.highScoresTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoresTextBox.Location = new System.Drawing.Point(12, 266);
            this.highScoresTextBox.Multiline = true;
            this.highScoresTextBox.Name = "highScoresTextBox";
            this.highScoresTextBox.ReadOnly = true;
            this.highScoresTextBox.Size = new System.Drawing.Size(502, 268);
            this.highScoresTextBox.TabIndex = 2;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(527, 581);
            this.Controls.Add(this.highScoresTextBox);
            this.Controls.Add(this.aboutFormCloseButton);
            this.Controls.Add(this.aboutTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.Load += new System.EventHandler(this.OnAboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.Button aboutFormCloseButton;
        private System.Windows.Forms.TextBox highScoresTextBox;
    }
}