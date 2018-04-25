using System;
using System.Windows.Forms;
using CS3020HW3Classes;
using MinesweeperGameClasses;

namespace CS3020HW2
{
    public partial class SetUpNewGameForm : Form
    {
        #region FormLevelFields

        readonly MainForm mainForm;

        #endregion

        public SetUpNewGameForm(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        void OnSetUpNewGameForm_Load(object sender, EventArgs e)
        {
            startGameButton.Select();
            difficultyChoiceBox.SelectedIndex = (int)mainForm.msGame.Diffaculty;
            Left = mainForm.Left + ((mainForm.Width - Width) / 2);
            Top = mainForm.Top + ((mainForm.Height - Height) / 2);
        }

        void OnStartGameButton_Click(object sender, EventArgs e)
        {
            mainForm.ResetGame((MinesweeperDifficulty)difficultyChoiceBox.SelectedIndex);
            Close();
        }
    }
}
