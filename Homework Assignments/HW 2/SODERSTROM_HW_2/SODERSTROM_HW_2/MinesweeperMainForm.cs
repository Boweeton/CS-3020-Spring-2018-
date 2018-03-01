using MinesweeperGameClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SODERSTROM_HW_2
{
    public partial class MinesweeperMainForm : Form
    {
        #region ClassLevelDeclarations

        int seconds = 60;
        const int ButtonSize = 30;
        const int BufferSize = 0;
        const int TopOffset = 50;
        MinesweeperGameManager gameManager = new MinesweeperGameManager(MinesweeperDiffaculty.Hard);
        Button[,] gameButtons;

        #endregion

        public MinesweeperMainForm()
        {
            InitializeComponent();
            gameManager.InitializeBoard();
            gameButtons = new Button[gameManager.CurrentGridSize, gameManager.CurrentGridSize];
            CreateButtons(gameManager);
            AlterFormSize(gameManager);
        }

        #region Events
        

        void OnMinesweeperMainFormLoad (object sender, EventArgs e)
        {
            gameTimer.Interval = 1000;
            gameTimer.Start();
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            seconds--;
            timerTextBox.Text = $"Time Left: {seconds}";

            if (seconds <= 0)
            {
                Close();
            }
        }

        void OnCloseGameButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region HelperMethods

        void CreateButtons (MinesweeperGameManager GM)
        {
            // Create the buttons
            for (int i = 0; i < GM.CurrentGridSize; i++)
            {
                for (int j = 0; j < GM.CurrentGridSize; j++)
                {
                    gameButtons[i, j] = new Button
                    {
                        Size = new Size(ButtonSize, ButtonSize),
                        Left = (i * (ButtonSize + BufferSize)),
                        Top = (j * (ButtonSize + BufferSize)) + TopOffset
                    };
                    gameButtons[i, j].Show();
                    Controls.Add(gameButtons[i, j]);
                }
            }
        }

        void AlterFormSize (MinesweeperGameManager GM)
        {
            // Resize the form size
            Width = ((GM.CurrentGridSize + 1) * (ButtonSize + BufferSize)) - 12;
            Height = ((GM.CurrentGridSize + 1) * (ButtonSize + BufferSize)) + TopOffset + 10;
        }

        void ClearButtons (MinesweeperGameManager GM)
        {
            // Itterate through each button
            for (int i = 0; i < GM.CurrentGridSize; i++)
            {
                for (int j = 0; j < GM.CurrentGridSize; j++)
                {
                    gameButtons[i, j].Dispose();
                }
            }
        }

        #endregion
    }
}
