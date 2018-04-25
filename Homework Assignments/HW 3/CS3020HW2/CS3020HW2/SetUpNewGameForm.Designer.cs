namespace CS3020HW2
{
    partial class SetUpNewGameForm
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
            this.difficultyChoiceBox = new System.Windows.Forms.ComboBox();
            this.difficultyChoiceLabel = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // difficultyChoiceBox
            // 
            this.difficultyChoiceBox.BackColor = System.Drawing.SystemColors.Control;
            this.difficultyChoiceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyChoiceBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyChoiceBox.ForeColor = System.Drawing.Color.Black;
            this.difficultyChoiceBox.FormattingEnabled = true;
            this.difficultyChoiceBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Insain"});
            this.difficultyChoiceBox.Location = new System.Drawing.Point(24, 35);
            this.difficultyChoiceBox.Name = "difficultyChoiceBox";
            this.difficultyChoiceBox.Size = new System.Drawing.Size(121, 23);
            this.difficultyChoiceBox.TabIndex = 0;
            // 
            // difficultyChoiceLabel
            // 
            this.difficultyChoiceLabel.AutoSize = true;
            this.difficultyChoiceLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyChoiceLabel.Location = new System.Drawing.Point(24, 16);
            this.difficultyChoiceLabel.Name = "difficultyChoiceLabel";
            this.difficultyChoiceLabel.Size = new System.Drawing.Size(77, 15);
            this.difficultyChoiceLabel.TabIndex = 1;
            this.difficultyChoiceLabel.Text = "Diffaculty";
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.SystemColors.Control;
            this.startGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGameButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.ForeColor = System.Drawing.Color.Black;
            this.startGameButton.Location = new System.Drawing.Point(24, 77);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(121, 32);
            this.startGameButton.TabIndex = 2;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.OnStartGameButton_Click);
            // 
            // SetUpNewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 138);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.difficultyChoiceLabel);
            this.Controls.Add(this.difficultyChoiceBox);
            this.Name = "SetUpNewGameForm";
            this.Load += new System.EventHandler(this.OnSetUpNewGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox difficultyChoiceBox;
        private System.Windows.Forms.Label difficultyChoiceLabel;
        private System.Windows.Forms.Button startGameButton;
    }
}