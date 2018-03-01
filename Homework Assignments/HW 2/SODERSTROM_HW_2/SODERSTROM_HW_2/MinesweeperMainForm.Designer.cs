namespace SODERSTROM_HW_2
{
    partial class MinesweeperMainForm
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
            this.components = new System.ComponentModel.Container();
            this.timerTextBox = new System.Windows.Forms.TextBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.closeGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerTextBox
            // 
            this.timerTextBox.Location = new System.Drawing.Point(13, 13);
            this.timerTextBox.Name = "timerTextBox";
            this.timerTextBox.ReadOnly = true;
            this.timerTextBox.Size = new System.Drawing.Size(132, 22);
            this.timerTextBox.TabIndex = 0;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // closeGameButton
            // 
            this.closeGameButton.Location = new System.Drawing.Point(599, 12);
            this.closeGameButton.Name = "closeGameButton";
            this.closeGameButton.Size = new System.Drawing.Size(141, 23);
            this.closeGameButton.TabIndex = 1;
            this.closeGameButton.Text = "Close the Game";
            this.closeGameButton.UseVisualStyleBackColor = true;
            this.closeGameButton.Click += new System.EventHandler(this.OnCloseGameButtonClick);
            // 
            // MinesweeperMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 628);
            this.Controls.Add(this.closeGameButton);
            this.Controls.Add(this.timerTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MinesweeperMainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnMinesweeperMainFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timerTextBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button closeGameButton;
    }
}

