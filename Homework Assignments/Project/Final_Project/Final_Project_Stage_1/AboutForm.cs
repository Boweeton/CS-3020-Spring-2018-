using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Stage_1
{
    public partial class AboutForm : Form
    {
        #region Regions

        MainForm mainForm;

        #endregion

        public AboutForm(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        void closeFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void AboutForm_Load(object sender, EventArgs e)
        {
            // Center the form on the mainForm
            Left = mainForm.Left + ((mainForm.Width - Width) / 2);
            Top = mainForm.Top + ((mainForm.Height - Height) / 2);

            // Build the strings
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Created by Luke Soderstrom");
            stringBuilder.AppendLine("For CS - 3200");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"Best Score: {mainForm.LifetimeStats.MostRoundsAchieved} rounds");

            aboutTextBox.Text = stringBuilder.ToString();
        }
    }
}
