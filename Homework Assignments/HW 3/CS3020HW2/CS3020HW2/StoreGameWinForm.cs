using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS3020HW3Classes;
using MinesweeperGameClasses;

namespace CS3020HW2
{
    public partial class StoreGameWinForm : Form
    {
        #region FormLevelFields

        readonly MinesweeperLifetimeStats lifetimeStats;
        readonly int time;
        readonly MinesweeperDifficulty difficulty;
        readonly string filePath;
        MainForm mainForm;
        const int NameLengthLimit = 10;

        #endregion

        public StoreGameWinForm(MainForm f, MinesweeperLifetimeStats stats, int currentTime, MinesweeperDifficulty currentDifficulty, string newPath)
        {
            InitializeComponent();
            mainForm = f;
            lifetimeStats = stats;
            time = currentTime;
            difficulty = currentDifficulty;
            filePath = newPath;
        }

        void OnPlayAgainButton_Click(object sender, EventArgs e)
        {
            if (nameFieldBox.Text != string.Empty && nameFieldBox.Text.Length <= NameLengthLimit)
            {
                StoreStat();
                mainForm.OpenNewGameDialog();
                Close();
            }
            else
            {
                if (nameFieldBox.Text == string.Empty)
                {
                    MessageBox.Show("No name entered");
                }

                if (nameFieldBox.Text.Length > NameLengthLimit)
                {
                    MessageBox.Show("Enter shorter name");
                }
            }
        }

        void OnQuitGameButton_Click(object sender, EventArgs e)
        {
            if (nameFieldBox.Text != string.Empty && nameFieldBox.Text.Length <= NameLengthLimit)
            {
                StoreStat();
                mainForm.Close();
                Close();
            }
            else
            {
                if (nameFieldBox.Text == string.Empty)
                {
                    MessageBox.Show("No name entered");
                }

                if (nameFieldBox.Text.Length > NameLengthLimit)
                {
                    MessageBox.Show("Enter shorter name");
                }
            }
        }

        void OnStoreGameWinForm_Load(object sender, EventArgs e)
        {
            Left = mainForm.Left + ((mainForm.Width - Width) / 2);
            Top = mainForm.Top + ((mainForm.Height - Height) / 2);
        }

        void StoreStat()
        {
            // Create new score
            HighScoreRecord tmp = new HighScoreRecord(nameFieldBox.Text, time, difficulty);
            lifetimeStats.HighScores.Add(tmp);
            lifetimeStats.LifetimeWins++;

            Util.SerializeOut(lifetimeStats, filePath);
        }
    }
}
