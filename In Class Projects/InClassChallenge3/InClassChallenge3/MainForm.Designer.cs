namespace InClassChallenge3
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
            this.listSizeTextBox = new System.Windows.Forms.TextBox();
            this.listSizeLabel = new System.Windows.Forms.Label();
            this.generateIntsButton = new System.Windows.Forms.Button();
            this.generateDoublesButton = new System.Windows.Forms.Button();
            this.listValuesTextBox = new System.Windows.Forms.TextBox();
            this.listValuesBoxLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.searchGroupBox.SuspendLayout();
            this.searchResultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listSizeTextBox
            // 
            this.listSizeTextBox.Location = new System.Drawing.Point(13, 100);
            this.listSizeTextBox.Name = "listSizeTextBox";
            this.listSizeTextBox.Size = new System.Drawing.Size(46, 20);
            this.listSizeTextBox.TabIndex = 0;
            // 
            // listSizeLabel
            // 
            this.listSizeLabel.AutoSize = true;
            this.listSizeLabel.Location = new System.Drawing.Point(13, 81);
            this.listSizeLabel.Name = "listSizeLabel";
            this.listSizeLabel.Size = new System.Drawing.Size(46, 13);
            this.listSizeLabel.TabIndex = 1;
            this.listSizeLabel.Text = "List Size";
            // 
            // generateIntsButton
            // 
            this.generateIntsButton.Location = new System.Drawing.Point(13, 13);
            this.generateIntsButton.Name = "generateIntsButton";
            this.generateIntsButton.Size = new System.Drawing.Size(118, 23);
            this.generateIntsButton.TabIndex = 2;
            this.generateIntsButton.Text = "Fill List With Ints";
            this.generateIntsButton.UseVisualStyleBackColor = true;
            this.generateIntsButton.Click += new System.EventHandler(this.OnGenerateIntsButton_Click);
            // 
            // generateDoublesButton
            // 
            this.generateDoublesButton.Location = new System.Drawing.Point(13, 51);
            this.generateDoublesButton.Name = "generateDoublesButton";
            this.generateDoublesButton.Size = new System.Drawing.Size(118, 23);
            this.generateDoublesButton.TabIndex = 3;
            this.generateDoublesButton.Text = "Fill List With Doubles";
            this.generateDoublesButton.UseVisualStyleBackColor = true;
            this.generateDoublesButton.Click += new System.EventHandler(this.OnGenerateDoublesButton_Click);
            // 
            // listValuesTextBox
            // 
            this.listValuesTextBox.Location = new System.Drawing.Point(163, 35);
            this.listValuesTextBox.Multiline = true;
            this.listValuesTextBox.Name = "listValuesTextBox";
            this.listValuesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listValuesTextBox.Size = new System.Drawing.Size(118, 199);
            this.listValuesTextBox.TabIndex = 4;
            // 
            // listValuesBoxLabel
            // 
            this.listValuesBoxLabel.AutoSize = true;
            this.listValuesBoxLabel.Location = new System.Drawing.Point(195, 19);
            this.listValuesBoxLabel.Name = "listValuesBoxLabel";
            this.listValuesBoxLabel.Size = new System.Drawing.Size(58, 13);
            this.listValuesBoxLabel.TabIndex = 5;
            this.listValuesBoxLabel.Text = "List Values";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(6, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(91, 20);
            this.searchTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 55);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(91, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.OnSearchButton_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Location = new System.Drawing.Point(13, 143);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(111, 91);
            this.searchGroupBox.TabIndex = 9;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // searchResultsGroupBox
            // 
            this.searchResultsGroupBox.Controls.Add(this.searchResultsLabel);
            this.searchResultsGroupBox.Location = new System.Drawing.Point(19, 261);
            this.searchResultsGroupBox.Name = "searchResultsGroupBox";
            this.searchResultsGroupBox.Size = new System.Drawing.Size(262, 65);
            this.searchResultsGroupBox.TabIndex = 10;
            this.searchResultsGroupBox.TabStop = false;
            this.searchResultsGroupBox.Text = "Search Results";
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultsLabel.Location = new System.Drawing.Point(6, 16);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(136, 26);
            this.searchResultsLabel.TabIndex = 0;
            this.searchResultsLabel.Text = "First Index: _";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 349);
            this.Controls.Add(this.searchResultsGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.listValuesBoxLabel);
            this.Controls.Add(this.listValuesTextBox);
            this.Controls.Add(this.generateDoublesButton);
            this.Controls.Add(this.generateIntsButton);
            this.Controls.Add(this.listSizeLabel);
            this.Controls.Add(this.listSizeTextBox);
            this.Name = "MainForm";
            this.Text = "Dumb Search";
            this.Load += new System.EventHandler(this.OnMainForm_Load);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.searchResultsGroupBox.ResumeLayout(false);
            this.searchResultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox listSizeTextBox;
        private System.Windows.Forms.Label listSizeLabel;
        private System.Windows.Forms.Button generateIntsButton;
        private System.Windows.Forms.Button generateDoublesButton;
        private System.Windows.Forms.TextBox listValuesTextBox;
        private System.Windows.Forms.Label listValuesBoxLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.GroupBox searchResultsGroupBox;
        private System.Windows.Forms.Label searchResultsLabel;
    }
}

