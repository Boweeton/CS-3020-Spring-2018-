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
            this.villan2Button = new System.Windows.Forms.Button();
            this.villan1Button = new System.Windows.Forms.Button();
            this.villan0Button = new System.Windows.Forms.Button();
            this.hero2Button = new System.Windows.Forms.Button();
            this.hero1Button = new System.Windows.Forms.Button();
            this.hero0Button = new System.Windows.Forms.Button();
            this.combatLogTextBox = new System.Windows.Forms.TextBox();
            this.combatLogTextBoxLabel = new System.Windows.Forms.Label();
            this.action2Button = new System.Windows.Forms.Button();
            this.action1Button = new System.Windows.Forms.Button();
            this.action0Button = new System.Windows.Forms.Button();
            this.actionsLabel = new System.Windows.Forms.Label();
            this.gameActionsPanel = new System.Windows.Forms.Panel();
            this.combatLogPanel = new System.Windows.Forms.Panel();
            this.hero0StatusLabel = new System.Windows.Forms.Label();
            this.hero1StatusLabel = new System.Windows.Forms.Label();
            this.hero2StatusLabel = new System.Windows.Forms.Label();
            this.villan0StatusLabel = new System.Windows.Forms.Label();
            this.villan1StatusLabel = new System.Windows.Forms.Label();
            this.villan2StatusLabel = new System.Windows.Forms.Label();
            this.passTurnButton = new System.Windows.Forms.Button();
            this.gameMessageLabel = new System.Windows.Forms.Label();
            this.combatZonePanel.SuspendLayout();
            this.gameActionsPanel.SuspendLayout();
            this.combatLogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // combatZonePanel
            // 
            this.combatZonePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.combatZonePanel.Controls.Add(this.gameMessageLabel);
            this.combatZonePanel.Controls.Add(this.villan2StatusLabel);
            this.combatZonePanel.Controls.Add(this.villan1StatusLabel);
            this.combatZonePanel.Controls.Add(this.villan0StatusLabel);
            this.combatZonePanel.Controls.Add(this.hero2StatusLabel);
            this.combatZonePanel.Controls.Add(this.hero1StatusLabel);
            this.combatZonePanel.Controls.Add(this.hero0StatusLabel);
            this.combatZonePanel.Controls.Add(this.villan2Button);
            this.combatZonePanel.Controls.Add(this.villan1Button);
            this.combatZonePanel.Controls.Add(this.villan0Button);
            this.combatZonePanel.Controls.Add(this.hero2Button);
            this.combatZonePanel.Controls.Add(this.hero1Button);
            this.combatZonePanel.Controls.Add(this.hero0Button);
            this.combatZonePanel.Location = new System.Drawing.Point(12, 12);
            this.combatZonePanel.Name = "combatZonePanel";
            this.combatZonePanel.Size = new System.Drawing.Size(595, 322);
            this.combatZonePanel.TabIndex = 0;
            // 
            // villan2Button
            // 
            this.villan2Button.Location = new System.Drawing.Point(449, 238);
            this.villan2Button.Name = "villan2Button";
            this.villan2Button.Size = new System.Drawing.Size(60, 60);
            this.villan2Button.TabIndex = 5;
            this.villan2Button.UseVisualStyleBackColor = true;
            // 
            // villan1Button
            // 
            this.villan1Button.Location = new System.Drawing.Point(449, 124);
            this.villan1Button.Name = "villan1Button";
            this.villan1Button.Size = new System.Drawing.Size(60, 60);
            this.villan1Button.TabIndex = 4;
            this.villan1Button.UseVisualStyleBackColor = true;
            // 
            // villan0Button
            // 
            this.villan0Button.Location = new System.Drawing.Point(449, 17);
            this.villan0Button.Name = "villan0Button";
            this.villan0Button.Size = new System.Drawing.Size(60, 60);
            this.villan0Button.TabIndex = 3;
            this.villan0Button.UseVisualStyleBackColor = true;
            // 
            // hero2Button
            // 
            this.hero2Button.Location = new System.Drawing.Point(78, 238);
            this.hero2Button.Name = "hero2Button";
            this.hero2Button.Size = new System.Drawing.Size(60, 60);
            this.hero2Button.TabIndex = 2;
            this.hero2Button.UseVisualStyleBackColor = true;
            // 
            // hero1Button
            // 
            this.hero1Button.Location = new System.Drawing.Point(78, 124);
            this.hero1Button.Name = "hero1Button";
            this.hero1Button.Size = new System.Drawing.Size(60, 60);
            this.hero1Button.TabIndex = 1;
            this.hero1Button.UseVisualStyleBackColor = true;
            // 
            // hero0Button
            // 
            this.hero0Button.Location = new System.Drawing.Point(78, 14);
            this.hero0Button.Name = "hero0Button";
            this.hero0Button.Size = new System.Drawing.Size(60, 60);
            this.hero0Button.TabIndex = 0;
            this.hero0Button.UseVisualStyleBackColor = true;
            // 
            // combatLogTextBox
            // 
            this.combatLogTextBox.Font = new System.Drawing.Font("BlackChancery", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatLogTextBox.Location = new System.Drawing.Point(3, 22);
            this.combatLogTextBox.Multiline = true;
            this.combatLogTextBox.Name = "combatLogTextBox";
            this.combatLogTextBox.ReadOnly = true;
            this.combatLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.combatLogTextBox.Size = new System.Drawing.Size(279, 120);
            this.combatLogTextBox.TabIndex = 1;
            this.combatLogTextBox.TextChanged += new System.EventHandler(this.OnCombatLogTextBox_TextChanged);
            // 
            // combatLogTextBoxLabel
            // 
            this.combatLogTextBoxLabel.AutoSize = true;
            this.combatLogTextBoxLabel.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatLogTextBoxLabel.Location = new System.Drawing.Point(120, 0);
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
            // gameActionsPanel
            // 
            this.gameActionsPanel.Controls.Add(this.passTurnButton);
            this.gameActionsPanel.Controls.Add(this.actionsLabel);
            this.gameActionsPanel.Controls.Add(this.action2Button);
            this.gameActionsPanel.Controls.Add(this.action0Button);
            this.gameActionsPanel.Controls.Add(this.action1Button);
            this.gameActionsPanel.Location = new System.Drawing.Point(12, 354);
            this.gameActionsPanel.Name = "gameActionsPanel";
            this.gameActionsPanel.Size = new System.Drawing.Size(299, 162);
            this.gameActionsPanel.TabIndex = 3;
            // 
            // combatLogPanel
            // 
            this.combatLogPanel.Controls.Add(this.combatLogTextBox);
            this.combatLogPanel.Controls.Add(this.combatLogTextBoxLabel);
            this.combatLogPanel.Location = new System.Drawing.Point(317, 356);
            this.combatLogPanel.Name = "combatLogPanel";
            this.combatLogPanel.Size = new System.Drawing.Size(290, 162);
            this.combatLogPanel.TabIndex = 0;
            // 
            // hero0StatusLabel
            // 
            this.hero0StatusLabel.AutoSize = true;
            this.hero0StatusLabel.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hero0StatusLabel.Location = new System.Drawing.Point(13, 17);
            this.hero0StatusLabel.Name = "hero0StatusLabel";
            this.hero0StatusLabel.Size = new System.Drawing.Size(58, 57);
            this.hero0StatusLabel.TabIndex = 6;
            this.hero0StatusLabel.Text = "Knight\r\nHP: 38\r\nSP: 2";
            // 
            // hero1StatusLabel
            // 
            this.hero1StatusLabel.AutoSize = true;
            this.hero1StatusLabel.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hero1StatusLabel.Location = new System.Drawing.Point(13, 124);
            this.hero1StatusLabel.Name = "hero1StatusLabel";
            this.hero1StatusLabel.Size = new System.Drawing.Size(59, 57);
            this.hero1StatusLabel.TabIndex = 7;
            this.hero1StatusLabel.Text = "Wizard\r\nHP: 20\r\nSP: 4";
            // 
            // hero2StatusLabel
            // 
            this.hero2StatusLabel.AutoSize = true;
            this.hero2StatusLabel.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hero2StatusLabel.Location = new System.Drawing.Point(13, 238);
            this.hero2StatusLabel.Name = "hero2StatusLabel";
            this.hero2StatusLabel.Size = new System.Drawing.Size(60, 57);
            this.hero2StatusLabel.TabIndex = 8;
            this.hero2StatusLabel.Text = "Cleric\r\nHP: 26\r\nSP: 7";
            // 
            // villan0StatusLabel
            // 
            this.villan0StatusLabel.AutoSize = true;
            this.villan0StatusLabel.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villan0StatusLabel.Location = new System.Drawing.Point(515, 36);
            this.villan0StatusLabel.Name = "villan0StatusLabel";
            this.villan0StatusLabel.Size = new System.Drawing.Size(59, 19);
            this.villan0StatusLabel.TabIndex = 9;
            this.villan0StatusLabel.Text = "Dragon";
            // 
            // villan1StatusLabel
            // 
            this.villan1StatusLabel.AutoSize = true;
            this.villan1StatusLabel.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villan1StatusLabel.Location = new System.Drawing.Point(515, 146);
            this.villan1StatusLabel.Name = "villan1StatusLabel";
            this.villan1StatusLabel.Size = new System.Drawing.Size(43, 19);
            this.villan1StatusLabel.TabIndex = 10;
            this.villan1StatusLabel.Text = "Ogre";
            // 
            // villan2StatusLabel
            // 
            this.villan2StatusLabel.AutoSize = true;
            this.villan2StatusLabel.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villan2StatusLabel.Location = new System.Drawing.Point(515, 260);
            this.villan2StatusLabel.Name = "villan2StatusLabel";
            this.villan2StatusLabel.Size = new System.Drawing.Size(60, 19);
            this.villan2StatusLabel.TabIndex = 11;
            this.villan2StatusLabel.Text = "Bandito";
            // 
            // passTurnButton
            // 
            this.passTurnButton.Font = new System.Drawing.Font("BlackChancery", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTurnButton.Location = new System.Drawing.Point(162, 64);
            this.passTurnButton.Name = "passTurnButton";
            this.passTurnButton.Size = new System.Drawing.Size(110, 36);
            this.passTurnButton.TabIndex = 7;
            this.passTurnButton.Text = "Pass Turn";
            this.passTurnButton.UseVisualStyleBackColor = true;
            // 
            // gameMessageLabel
            // 
            this.gameMessageLabel.AutoSize = true;
            this.gameMessageLabel.Font = new System.Drawing.Font("BlackChancery", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameMessageLabel.Location = new System.Drawing.Point(205, 134);
            this.gameMessageLabel.Name = "gameMessageLabel";
            this.gameMessageLabel.Size = new System.Drawing.Size(186, 31);
            this.gameMessageLabel.TabIndex = 12;
            this.gameMessageLabel.Text = "(Game Message)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 529);
            this.Controls.Add(this.combatLogPanel);
            this.Controls.Add(this.gameActionsPanel);
            this.Controls.Add(this.combatZonePanel);
            this.Name = "MainForm";
            this.Text = "Final Project [JRPG] Mockup";
            this.combatZonePanel.ResumeLayout(false);
            this.combatZonePanel.PerformLayout();
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
        private System.Windows.Forms.Panel gameActionsPanel;
        private System.Windows.Forms.Panel combatLogPanel;
        private System.Windows.Forms.Button villan2Button;
        private System.Windows.Forms.Button villan1Button;
        private System.Windows.Forms.Button villan0Button;
        private System.Windows.Forms.Button hero2Button;
        private System.Windows.Forms.Button hero1Button;
        private System.Windows.Forms.Button hero0Button;
        private System.Windows.Forms.Label hero0StatusLabel;
        private System.Windows.Forms.Label hero1StatusLabel;
        private System.Windows.Forms.Label villan2StatusLabel;
        private System.Windows.Forms.Label villan1StatusLabel;
        private System.Windows.Forms.Label villan0StatusLabel;
        private System.Windows.Forms.Label hero2StatusLabel;
        private System.Windows.Forms.Button passTurnButton;
        private System.Windows.Forms.Label gameMessageLabel;
    }
}

