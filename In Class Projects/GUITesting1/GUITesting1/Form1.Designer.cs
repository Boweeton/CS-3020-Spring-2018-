namespace GUITesting1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.addItemsBox = new System.Windows.Forms.GroupBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.addItemsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.addItemsBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 499);
            this.panel1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 86);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // addItemsBox
            // 
            this.addItemsBox.Controls.Add(this.addEventButton);
            this.addItemsBox.Location = new System.Drawing.Point(3, 3);
            this.addItemsBox.Name = "addItemsBox";
            this.addItemsBox.Size = new System.Drawing.Size(178, 71);
            this.addItemsBox.TabIndex = 0;
            this.addItemsBox.TabStop = false;
            this.addItemsBox.Text = "Add Items";
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(6, 21);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(164, 37);
            this.addEventButton.TabIndex = 0;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.OnAddEventButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 523);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Day Planner";
            this.Load += new System.EventHandler(this.OnMainFormLoad);
            this.panel1.ResumeLayout(false);
            this.addItemsBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox addItemsBox;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

