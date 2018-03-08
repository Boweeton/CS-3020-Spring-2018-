namespace TempConverter
{
    partial class TempConverterMainForm
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
            this.sourceDataBox = new System.Windows.Forms.TextBox();
            this.targetDataBox = new System.Windows.Forms.TextBox();
            this.sourceUnitComboBox = new System.Windows.Forms.ComboBox();
            this.targetUnitComboBox = new System.Windows.Forms.ComboBox();
            this.runConversionButton = new System.Windows.Forms.Button();
            this.sourceDataLabel = new System.Windows.Forms.Label();
            this.targetDataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sourceDataBox
            // 
            this.sourceDataBox.Location = new System.Drawing.Point(12, 80);
            this.sourceDataBox.Name = "sourceDataBox";
            this.sourceDataBox.Size = new System.Drawing.Size(131, 22);
            this.sourceDataBox.TabIndex = 0;
            // 
            // targetDataBox
            // 
            this.targetDataBox.Location = new System.Drawing.Point(189, 80);
            this.targetDataBox.Name = "targetDataBox";
            this.targetDataBox.Size = new System.Drawing.Size(131, 22);
            this.targetDataBox.TabIndex = 1;
            this.targetDataBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sourceUnitComboBox
            // 
            this.sourceUnitComboBox.FormattingEnabled = true;
            this.sourceUnitComboBox.Location = new System.Drawing.Point(12, 49);
            this.sourceUnitComboBox.Name = "sourceUnitComboBox";
            this.sourceUnitComboBox.Size = new System.Drawing.Size(131, 24);
            this.sourceUnitComboBox.TabIndex = 2;
            // 
            // targetUnitComboBox
            // 
            this.targetUnitComboBox.FormattingEnabled = true;
            this.targetUnitComboBox.Location = new System.Drawing.Point(189, 49);
            this.targetUnitComboBox.Name = "targetUnitComboBox";
            this.targetUnitComboBox.Size = new System.Drawing.Size(131, 24);
            this.targetUnitComboBox.TabIndex = 3;
            // 
            // runConversionButton
            // 
            this.runConversionButton.Location = new System.Drawing.Point(112, 121);
            this.runConversionButton.Name = "runConversionButton";
            this.runConversionButton.Size = new System.Drawing.Size(113, 35);
            this.runConversionButton.TabIndex = 4;
            this.runConversionButton.Text = "Convert";
            this.runConversionButton.UseVisualStyleBackColor = true;
            this.runConversionButton.Click += new System.EventHandler(this.OnRunConversionButtonClick);
            // 
            // sourceDataLabel
            // 
            this.sourceDataLabel.AutoSize = true;
            this.sourceDataLabel.Location = new System.Drawing.Point(13, 26);
            this.sourceDataLabel.Name = "sourceDataLabel";
            this.sourceDataLabel.Size = new System.Drawing.Size(87, 17);
            this.sourceDataLabel.TabIndex = 5;
            this.sourceDataLabel.Text = "Source Data";
            // 
            // targetDataLabel
            // 
            this.targetDataLabel.AutoSize = true;
            this.targetDataLabel.Location = new System.Drawing.Point(233, 26);
            this.targetDataLabel.Name = "targetDataLabel";
            this.targetDataLabel.Size = new System.Drawing.Size(84, 17);
            this.targetDataLabel.TabIndex = 6;
            this.targetDataLabel.Text = "Target Data";
            // 
            // TempConverterMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 180);
            this.Controls.Add(this.targetDataLabel);
            this.Controls.Add(this.sourceDataLabel);
            this.Controls.Add(this.runConversionButton);
            this.Controls.Add(this.targetUnitComboBox);
            this.Controls.Add(this.sourceUnitComboBox);
            this.Controls.Add(this.targetDataBox);
            this.Controls.Add(this.sourceDataBox);
            this.Name = "TempConverterMainForm";
            this.Text = "Temp Converter";
            this.Load += new System.EventHandler(this.OnTempConverterMainFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceDataBox;
        private System.Windows.Forms.TextBox targetDataBox;
        private System.Windows.Forms.ComboBox sourceUnitComboBox;
        private System.Windows.Forms.ComboBox targetUnitComboBox;
        private System.Windows.Forms.Button runConversionButton;
        private System.Windows.Forms.Label sourceDataLabel;
        private System.Windows.Forms.Label targetDataLabel;
    }
}

