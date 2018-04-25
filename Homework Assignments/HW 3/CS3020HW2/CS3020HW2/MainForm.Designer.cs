namespace CS3020HW2
{
    partial class MainForm
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.restartGameButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.timeerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.OnGameTimer_Tick);
            // 
            // restartGameButton
            // 
            this.restartGameButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartGameButton.Location = new System.Drawing.Point(13, 13);
            this.restartGameButton.Name = "restartGameButton";
            this.restartGameButton.Size = new System.Drawing.Size(80, 23);
            this.restartGameButton.TabIndex = 0;
            this.restartGameButton.Text = "New Game";
            this.restartGameButton.UseVisualStyleBackColor = true;
            this.restartGameButton.Click += new System.EventHandler(this.OnRestartGameButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Location = new System.Drawing.Point(208, 12);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(79, 23);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.OnAboutButton_Click);
            // 
            // timeerTextBox
            // 
            this.timeerTextBox.BackColor = System.Drawing.Color.Black;
            this.timeerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeerTextBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeerTextBox.ForeColor = System.Drawing.Color.DarkRed;
            this.timeerTextBox.Location = new System.Drawing.Point(117, 16);
            this.timeerTextBox.Name = "timeerTextBox";
            this.timeerTextBox.Size = new System.Drawing.Size(55, 25);
            this.timeerTextBox.TabIndex = 2;
            this.timeerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(299, 302);
            this.Controls.Add(this.timeerTextBox);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.restartGameButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Luke\'s Minesweeper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnMainFormClosed);
            this.Load += new System.EventHandler(this.OnMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button restartGameButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.TextBox timeerTextBox;
    }
}

