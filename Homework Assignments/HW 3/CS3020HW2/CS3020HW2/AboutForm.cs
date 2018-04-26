using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3020HW2
{
    public partial class AboutForm : Form
    {
        #region FormLevelFields

        readonly MainForm mainForm;
        readonly string aboutInfo;
        readonly string highScoreInfo;

        #endregion

        public AboutForm(MainForm mf, string newAboutInfo, string newHighScoreInfo)
        {
            InitializeComponent();
            mainForm = mf;
            aboutInfo = newAboutInfo;
            highScoreInfo = newHighScoreInfo;
        }

        void OnAboutForm_Load(object sender, EventArgs e)
        {
            aboutTextBox.Text = aboutInfo;
            highScoresTextBox.Text = highScoreInfo;
            aboutFormCloseButton.Select();
            Left = mainForm.Left + ((mainForm.Width - Width) / 2);
            Top = mainForm.Top + ((mainForm.Height - Height) / 2);
        }

        void OnAboutFormCloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
