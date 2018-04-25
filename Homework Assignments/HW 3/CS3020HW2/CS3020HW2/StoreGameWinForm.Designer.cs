namespace CS3020HW2
{
    partial class StoreGameWinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreGameWinForm));
            this.nameFieldBox = new System.Windows.Forms.TextBox();
            this.namFieldLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.quitGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameFieldBox
            // 
            this.nameFieldBox.Location = new System.Drawing.Point(13, 38);
            this.nameFieldBox.Name = "nameFieldBox";
            this.nameFieldBox.Size = new System.Drawing.Size(222, 20);
            this.nameFieldBox.TabIndex = 0;
            // 
            // namFieldLabel
            // 
            this.namFieldLabel.AutoSize = true;
            this.namFieldLabel.Location = new System.Drawing.Point(13, 19);
            this.namFieldLabel.Name = "namFieldLabel";
            this.namFieldLabel.Size = new System.Drawing.Size(35, 13);
            this.namFieldLabel.TabIndex = 1;
            this.namFieldLabel.Text = "Name";
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(13, 80);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(101, 23);
            this.playAgainButton.TabIndex = 2;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.OnPlayAgainButton_Click);
            // 
            // quitGameButton
            // 
            this.quitGameButton.Location = new System.Drawing.Point(134, 80);
            this.quitGameButton.Name = "quitGameButton";
            this.quitGameButton.Size = new System.Drawing.Size(101, 23);
            this.quitGameButton.TabIndex = 3;
            this.quitGameButton.Text = "Quit Game";
            this.quitGameButton.UseVisualStyleBackColor = true;
            this.quitGameButton.Click += new System.EventHandler(this.OnQuitGameButton_Click);
            // 
            // StoreGameWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 131);
            this.Controls.Add(this.quitGameButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.namFieldLabel);
            this.Controls.Add(this.nameFieldBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StoreGameWinForm";
            this.Text = "You Win!";
            this.Load += new System.EventHandler(this.OnStoreGameWinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameFieldBox;
        private System.Windows.Forms.Label namFieldLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button quitGameButton;
    }
}