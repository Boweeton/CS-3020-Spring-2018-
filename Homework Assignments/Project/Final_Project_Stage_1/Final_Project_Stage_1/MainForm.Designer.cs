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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.combatZonePanel = new System.Windows.Forms.Panel();
            this.enemy2CheckBox = new System.Windows.Forms.CheckBox();
            this.enemy1CheckBox = new System.Windows.Forms.CheckBox();
            this.enemy0CheckBox = new System.Windows.Forms.CheckBox();
            this.hero2CheckBox = new System.Windows.Forms.CheckBox();
            this.hero1CheckBox = new System.Windows.Forms.CheckBox();
            this.hero0CheckBox = new System.Windows.Forms.CheckBox();
            this.gameMessageLabel = new System.Windows.Forms.Label();
            this.villan2StatusLabel = new System.Windows.Forms.Label();
            this.villan1StatusLabel = new System.Windows.Forms.Label();
            this.villan0StatusLabel = new System.Windows.Forms.Label();
            this.hero2StatusLabel = new System.Windows.Forms.Label();
            this.hero1StatusLabel = new System.Windows.Forms.Label();
            this.hero0StatusLabel = new System.Windows.Forms.Label();
            this.combatLogTextBox = new System.Windows.Forms.TextBox();
            this.gameLogTextBoxLabel = new System.Windows.Forms.Label();
            this.action1Button = new System.Windows.Forms.Button();
            this.action0Button = new System.Windows.Forms.Button();
            this.actionsLabel = new System.Windows.Forms.Label();
            this.gameActionsPanel = new System.Windows.Forms.Panel();
            this.combatLogPanel = new System.Windows.Forms.Panel();
            this.combatZonePanel.SuspendLayout();
            this.gameActionsPanel.SuspendLayout();
            this.combatLogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // combatZonePanel
            // 
            this.combatZonePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.combatZonePanel.Controls.Add(this.enemy2CheckBox);
            this.combatZonePanel.Controls.Add(this.enemy1CheckBox);
            this.combatZonePanel.Controls.Add(this.enemy0CheckBox);
            this.combatZonePanel.Controls.Add(this.hero2CheckBox);
            this.combatZonePanel.Controls.Add(this.hero1CheckBox);
            this.combatZonePanel.Controls.Add(this.hero0CheckBox);
            this.combatZonePanel.Controls.Add(this.gameMessageLabel);
            this.combatZonePanel.Controls.Add(this.villan2StatusLabel);
            this.combatZonePanel.Controls.Add(this.villan1StatusLabel);
            this.combatZonePanel.Controls.Add(this.villan0StatusLabel);
            this.combatZonePanel.Controls.Add(this.hero2StatusLabel);
            this.combatZonePanel.Controls.Add(this.hero1StatusLabel);
            this.combatZonePanel.Controls.Add(this.hero0StatusLabel);
            this.combatZonePanel.Location = new System.Drawing.Point(12, 12);
            this.combatZonePanel.Name = "combatZonePanel";
            this.combatZonePanel.Size = new System.Drawing.Size(595, 322);
            this.combatZonePanel.TabIndex = 0;
            // 
            // enemy2CheckBox
            // 
            this.enemy2CheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.enemy2CheckBox.AutoSize = true;
            this.enemy2CheckBox.Image = ((System.Drawing.Image)(resources.GetObject("enemy2CheckBox.Image")));
            this.enemy2CheckBox.Location = new System.Drawing.Point(457, 243);
            this.enemy2CheckBox.Name = "enemy2CheckBox";
            this.enemy2CheckBox.Padding = new System.Windows.Forms.Padding(9);
            this.enemy2CheckBox.Size = new System.Drawing.Size(51, 51);
            this.enemy2CheckBox.TabIndex = 19;
            this.enemy2CheckBox.UseVisualStyleBackColor = true;
            this.enemy2CheckBox.CheckedChanged += new System.EventHandler(this.OnEnemy2CheckChanged);
            // 
            // enemy1CheckBox
            // 
            this.enemy1CheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.enemy1CheckBox.AutoSize = true;
            this.enemy1CheckBox.Image = ((System.Drawing.Image)(resources.GetObject("enemy1CheckBox.Image")));
            this.enemy1CheckBox.Location = new System.Drawing.Point(458, 126);
            this.enemy1CheckBox.Name = "enemy1CheckBox";
            this.enemy1CheckBox.Padding = new System.Windows.Forms.Padding(9);
            this.enemy1CheckBox.Size = new System.Drawing.Size(51, 51);
            this.enemy1CheckBox.TabIndex = 18;
            this.enemy1CheckBox.UseVisualStyleBackColor = true;
            this.enemy1CheckBox.CheckedChanged += new System.EventHandler(this.OnEnemy1CheckChanged);
            // 
            // enemy0CheckBox
            // 
            this.enemy0CheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.enemy0CheckBox.AutoSize = true;
            this.enemy0CheckBox.Image = ((System.Drawing.Image)(resources.GetObject("enemy0CheckBox.Image")));
            this.enemy0CheckBox.Location = new System.Drawing.Point(457, 19);
            this.enemy0CheckBox.Name = "enemy0CheckBox";
            this.enemy0CheckBox.Padding = new System.Windows.Forms.Padding(9);
            this.enemy0CheckBox.Size = new System.Drawing.Size(51, 51);
            this.enemy0CheckBox.TabIndex = 17;
            this.enemy0CheckBox.UseVisualStyleBackColor = true;
            this.enemy0CheckBox.CheckedChanged += new System.EventHandler(this.OnEnemy0CheckChanged);
            // 
            // hero2CheckBox
            // 
            this.hero2CheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.hero2CheckBox.AutoSize = true;
            this.hero2CheckBox.Image = ((System.Drawing.Image)(resources.GetObject("hero2CheckBox.Image")));
            this.hero2CheckBox.Location = new System.Drawing.Point(77, 243);
            this.hero2CheckBox.Name = "hero2CheckBox";
            this.hero2CheckBox.Padding = new System.Windows.Forms.Padding(9);
            this.hero2CheckBox.Size = new System.Drawing.Size(51, 51);
            this.hero2CheckBox.TabIndex = 16;
            this.hero2CheckBox.UseVisualStyleBackColor = true;
            this.hero2CheckBox.CheckedChanged += new System.EventHandler(this.OnHero2CheckChanged);
            // 
            // hero1CheckBox
            // 
            this.hero1CheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.hero1CheckBox.AutoSize = true;
            this.hero1CheckBox.Image = ((System.Drawing.Image)(resources.GetObject("hero1CheckBox.Image")));
            this.hero1CheckBox.Location = new System.Drawing.Point(78, 126);
            this.hero1CheckBox.Name = "hero1CheckBox";
            this.hero1CheckBox.Padding = new System.Windows.Forms.Padding(9);
            this.hero1CheckBox.Size = new System.Drawing.Size(51, 51);
            this.hero1CheckBox.TabIndex = 15;
            this.hero1CheckBox.UseVisualStyleBackColor = true;
            this.hero1CheckBox.CheckedChanged += new System.EventHandler(this.OnHero1CheckChanged);
            // 
            // hero0CheckBox
            // 
            this.hero0CheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.hero0CheckBox.AutoSize = true;
            this.hero0CheckBox.Image = ((System.Drawing.Image)(resources.GetObject("hero0CheckBox.Image")));
            this.hero0CheckBox.Location = new System.Drawing.Point(77, 19);
            this.hero0CheckBox.Name = "hero0CheckBox";
            this.hero0CheckBox.Padding = new System.Windows.Forms.Padding(9);
            this.hero0CheckBox.Size = new System.Drawing.Size(51, 51);
            this.hero0CheckBox.TabIndex = 14;
            this.hero0CheckBox.UseVisualStyleBackColor = true;
            this.hero0CheckBox.CheckedChanged += new System.EventHandler(this.OnHero0CheckChanged);
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
            // combatLogTextBox
            // 
            this.combatLogTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatLogTextBox.Location = new System.Drawing.Point(3, 22);
            this.combatLogTextBox.Multiline = true;
            this.combatLogTextBox.Name = "combatLogTextBox";
            this.combatLogTextBox.ReadOnly = true;
            this.combatLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.combatLogTextBox.Size = new System.Drawing.Size(430, 139);
            this.combatLogTextBox.TabIndex = 1;
            this.combatLogTextBox.TextChanged += new System.EventHandler(this.OnCombatLogTextBox_TextChanged);
            // 
            // gameLogTextBoxLabel
            // 
            this.gameLogTextBoxLabel.AutoSize = true;
            this.gameLogTextBoxLabel.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLogTextBoxLabel.Location = new System.Drawing.Point(173, -2);
            this.gameLogTextBoxLabel.Name = "gameLogTextBoxLabel";
            this.gameLogTextBoxLabel.Size = new System.Drawing.Size(75, 19);
            this.gameLogTextBoxLabel.TabIndex = 2;
            this.gameLogTextBoxLabel.Text = "Game Log";
            // 
            // action1Button
            // 
            this.action1Button.Enabled = false;
            this.action1Button.Font = new System.Drawing.Font("BlackChancery", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action1Button.Location = new System.Drawing.Point(12, 88);
            this.action1Button.Name = "action1Button";
            this.action1Button.Size = new System.Drawing.Size(110, 55);
            this.action1Button.TabIndex = 4;
            this.action1Button.UseVisualStyleBackColor = true;
            this.action1Button.Click += new System.EventHandler(this.OnAction1Button_Click);
            // 
            // action0Button
            // 
            this.action0Button.Font = new System.Drawing.Font("BlackChancery", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action0Button.Location = new System.Drawing.Point(12, 22);
            this.action0Button.Name = "action0Button";
            this.action0Button.Size = new System.Drawing.Size(110, 55);
            this.action0Button.TabIndex = 5;
            this.action0Button.Text = "Attack!";
            this.action0Button.UseVisualStyleBackColor = true;
            this.action0Button.Click += new System.EventHandler(this.OnAction0Button_Click);
            // 
            // actionsLabel
            // 
            this.actionsLabel.AutoSize = true;
            this.actionsLabel.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionsLabel.Location = new System.Drawing.Point(26, 0);
            this.actionsLabel.Name = "actionsLabel";
            this.actionsLabel.Size = new System.Drawing.Size(87, 19);
            this.actionsLabel.TabIndex = 6;
            this.actionsLabel.Text = "Take Action";
            // 
            // gameActionsPanel
            // 
            this.gameActionsPanel.Controls.Add(this.actionsLabel);
            this.gameActionsPanel.Controls.Add(this.action0Button);
            this.gameActionsPanel.Controls.Add(this.action1Button);
            this.gameActionsPanel.Location = new System.Drawing.Point(12, 354);
            this.gameActionsPanel.Name = "gameActionsPanel";
            this.gameActionsPanel.Size = new System.Drawing.Size(139, 162);
            this.gameActionsPanel.TabIndex = 3;
            // 
            // combatLogPanel
            // 
            this.combatLogPanel.Controls.Add(this.combatLogTextBox);
            this.combatLogPanel.Controls.Add(this.gameLogTextBoxLabel);
            this.combatLogPanel.Location = new System.Drawing.Point(171, 354);
            this.combatLogPanel.Name = "combatLogPanel";
            this.combatLogPanel.Size = new System.Drawing.Size(436, 164);
            this.combatLogPanel.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.OnMainForm_Load);
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
        private System.Windows.Forms.Label gameLogTextBoxLabel;
        private System.Windows.Forms.Button action1Button;
        private System.Windows.Forms.Button action0Button;
        private System.Windows.Forms.Label actionsLabel;
        private System.Windows.Forms.Panel gameActionsPanel;
        private System.Windows.Forms.Panel combatLogPanel;
        private System.Windows.Forms.Label hero0StatusLabel;
        private System.Windows.Forms.Label hero1StatusLabel;
        private System.Windows.Forms.Label villan2StatusLabel;
        private System.Windows.Forms.Label villan1StatusLabel;
        private System.Windows.Forms.Label villan0StatusLabel;
        private System.Windows.Forms.Label hero2StatusLabel;
        private System.Windows.Forms.Label gameMessageLabel;
        private System.Windows.Forms.CheckBox hero0CheckBox;
        private System.Windows.Forms.CheckBox hero2CheckBox;
        private System.Windows.Forms.CheckBox hero1CheckBox;
        private System.Windows.Forms.CheckBox enemy2CheckBox;
        private System.Windows.Forms.CheckBox enemy1CheckBox;
        private System.Windows.Forms.CheckBox enemy0CheckBox;
    }
}

