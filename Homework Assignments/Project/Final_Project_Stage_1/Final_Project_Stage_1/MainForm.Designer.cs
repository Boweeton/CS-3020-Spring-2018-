namespace Final_Project_Stage_1
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
            this.combatZonePanel = new System.Windows.Forms.Panel();
            this.combatLogTextBox = new System.Windows.Forms.TextBox();
            this.combatLogTextBoxLabel = new System.Windows.Forms.Label();
            this.action2Button = new System.Windows.Forms.Button();
            this.action1Button = new System.Windows.Forms.Button();
            this.action0Button = new System.Windows.Forms.Button();
            this.actionsLabel = new System.Windows.Forms.Label();
            this.targetsLabel = new System.Windows.Forms.Label();
            this.target0Button = new System.Windows.Forms.Button();
            this.target1Button = new System.Windows.Forms.Button();
            this.target2Button = new System.Windows.Forms.Button();
            this.gameActionsPanel = new System.Windows.Forms.Panel();
            this.combatLogPanel = new System.Windows.Forms.Panel();
            this.gameActionsPanel.SuspendLayout();
            this.combatLogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // combatZonePanel
            // 
            this.combatZonePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.combatZonePanel.Location = new System.Drawing.Point(13, 13);
            this.combatZonePanel.Name = "combatZonePanel";
            this.combatZonePanel.Size = new System.Drawing.Size(550, 256);
            this.combatZonePanel.TabIndex = 0;
            // 
            // combatLogTextBox
            // 
            this.combatLogTextBox.Font = new System.Drawing.Font("BlackChancery", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatLogTextBox.Location = new System.Drawing.Point(3, 22);
            this.combatLogTextBox.Multiline = true;
            this.combatLogTextBox.Name = "combatLogTextBox";
            this.combatLogTextBox.ReadOnly = true;
            this.combatLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.combatLogTextBox.Size = new System.Drawing.Size(266, 120);
            this.combatLogTextBox.TabIndex = 1;
            this.combatLogTextBox.TextChanged += new System.EventHandler(this.OnCombatLogTextBox_TextChanged);
            // 
            // combatLogTextBoxLabel
            // 
            this.combatLogTextBoxLabel.AutoSize = true;
            this.combatLogTextBoxLabel.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatLogTextBoxLabel.Location = new System.Drawing.Point(86, 0);
            this.combatLogTextBoxLabel.Name = "combatLogTextBoxLabel";
            this.combatLogTextBoxLabel.Size = new System.Drawing.Size(83, 19);
            this.combatLogTextBoxLabel.TabIndex = 2;
            this.combatLogTextBoxLabel.Text = "Combat Log";
            // 
            // action2Button
            // 
            this.action2Button.Font = new System.Drawing.Font("BlackChancery", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action2Button.Location = new System.Drawing.Point(13, 106);
            this.action2Button.Name = "action2Button";
            this.action2Button.Size = new System.Drawing.Size(110, 36);
            this.action2Button.TabIndex = 3;
            this.action2Button.Text = "Action 3";
            this.action2Button.UseVisualStyleBackColor = true;
            this.action2Button.Click += new System.EventHandler(this.OnAction2Button_Click);
            // 
            // action1Button
            // 
            this.action1Button.Font = new System.Drawing.Font("BlackChancery", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action1Button.Location = new System.Drawing.Point(12, 64);
            this.action1Button.Name = "action1Button";
            this.action1Button.Size = new System.Drawing.Size(110, 36);
            this.action1Button.TabIndex = 4;
            this.action1Button.Text = "Action 2";
            this.action1Button.UseVisualStyleBackColor = true;
            this.action1Button.Click += new System.EventHandler(this.OnAction1Button_Click);
            // 
            // action0Button
            // 
            this.action0Button.Font = new System.Drawing.Font("BlackChancery", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action0Button.Location = new System.Drawing.Point(12, 22);
            this.action0Button.Name = "action0Button";
            this.action0Button.Size = new System.Drawing.Size(110, 36);
            this.action0Button.TabIndex = 5;
            this.action0Button.Text = "Action 1";
            this.action0Button.UseVisualStyleBackColor = true;
            this.action0Button.Click += new System.EventHandler(this.OnAction0Button_Click);
            // 
            // actionsLabel
            // 
            this.actionsLabel.AutoSize = true;
            this.actionsLabel.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionsLabel.Location = new System.Drawing.Point(17, 2);
            this.actionsLabel.Name = "actionsLabel";
            this.actionsLabel.Size = new System.Drawing.Size(105, 19);
            this.actionsLabel.TabIndex = 6;
            this.actionsLabel.Text = "Take an Action";
            // 
            // targetsLabel
            // 
            this.targetsLabel.AutoSize = true;
            this.targetsLabel.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetsLabel.Location = new System.Drawing.Point(160, 2);
            this.targetsLabel.Name = "targetsLabel";
            this.targetsLabel.Size = new System.Drawing.Size(70, 19);
            this.targetsLabel.TabIndex = 10;
            this.targetsLabel.Text = "Targeting";
            // 
            // target0Button
            // 
            this.target0Button.Location = new System.Drawing.Point(128, 22);
            this.target0Button.Name = "target0Button";
            this.target0Button.Size = new System.Drawing.Size(140, 36);
            this.target0Button.TabIndex = 9;
            this.target0Button.Text = "(auto-filled target)";
            this.target0Button.UseVisualStyleBackColor = true;
            // 
            // target1Button
            // 
            this.target1Button.Location = new System.Drawing.Point(128, 64);
            this.target1Button.Name = "target1Button";
            this.target1Button.Size = new System.Drawing.Size(140, 36);
            this.target1Button.TabIndex = 8;
            this.target1Button.Text = "(auto-filled target)";
            this.target1Button.UseVisualStyleBackColor = true;
            // 
            // target2Button
            // 
            this.target2Button.Location = new System.Drawing.Point(129, 106);
            this.target2Button.Name = "target2Button";
            this.target2Button.Size = new System.Drawing.Size(140, 36);
            this.target2Button.TabIndex = 7;
            this.target2Button.Text = "(auto-filled target)";
            this.target2Button.UseVisualStyleBackColor = true;
            // 
            // gameActionsPanel
            // 
            this.gameActionsPanel.Controls.Add(this.targetsLabel);
            this.gameActionsPanel.Controls.Add(this.target0Button);
            this.gameActionsPanel.Controls.Add(this.actionsLabel);
            this.gameActionsPanel.Controls.Add(this.action2Button);
            this.gameActionsPanel.Controls.Add(this.action0Button);
            this.gameActionsPanel.Controls.Add(this.target1Button);
            this.gameActionsPanel.Controls.Add(this.target2Button);
            this.gameActionsPanel.Controls.Add(this.action1Button);
            this.gameActionsPanel.Location = new System.Drawing.Point(13, 291);
            this.gameActionsPanel.Name = "gameActionsPanel";
            this.gameActionsPanel.Size = new System.Drawing.Size(271, 162);
            this.gameActionsPanel.TabIndex = 3;
            // 
            // combatLogPanel
            // 
            this.combatLogPanel.Controls.Add(this.combatLogTextBox);
            this.combatLogPanel.Controls.Add(this.combatLogTextBoxLabel);
            this.combatLogPanel.Location = new System.Drawing.Point(290, 291);
            this.combatLogPanel.Name = "combatLogPanel";
            this.combatLogPanel.Size = new System.Drawing.Size(273, 162);
            this.combatLogPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 465);
            this.Controls.Add(this.combatLogPanel);
            this.Controls.Add(this.gameActionsPanel);
            this.Controls.Add(this.combatZonePanel);
            this.Name = "MainForm";
            this.Text = "Final Project [JRPG] Mockup";
            this.gameActionsPanel.ResumeLayout(false);
            this.gameActionsPanel.PerformLayout();
            this.combatLogPanel.ResumeLayout(false);
            this.combatLogPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel combatZonePanel;
        private System.Windows.Forms.TextBox combatLogTextBox;
        private System.Windows.Forms.Label combatLogTextBoxLabel;
        private System.Windows.Forms.Button action2Button;
        private System.Windows.Forms.Button action1Button;
        private System.Windows.Forms.Button action0Button;
        private System.Windows.Forms.Label actionsLabel;
        private System.Windows.Forms.Label targetsLabel;
        private System.Windows.Forms.Button target0Button;
        private System.Windows.Forms.Button target1Button;
        private System.Windows.Forms.Button target2Button;
        private System.Windows.Forms.Panel gameActionsPanel;
        private System.Windows.Forms.Panel combatLogPanel;
    }
}

