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

        const int ButtonSize = 30;
        const int BufferSize = 0;
        const int TopOffset = 50;
        MinesweeperGameManager gameManager = new MinesweeperGameManager(MinesweeperDiffaculty.Easy);
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
        
        private void OnMinesweeperMainFormLoad (object sender, EventArgs e)
        {
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
            for (int i = 0; i < GM.CurrentGridSize; i++)
            {
                for (int j = 0; j < GM.CurrentGridSize; j++)
                {
                    gameButtons[i, j].Dispose();
                }
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            gameManager.Diffaculty = MinesweeperDiffaculty.Easy;
            ClearButtons(gameManager);
            gameManager.CurrentGridSize = 10;
            CreateButtons(gameManager);
            AlterFormSize(gameManager);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameManager.Diffaculty = MinesweeperDiffaculty.Medium;
            ClearButtons(gameManager);
            gameManager.CurrentGridSize = 15;
            CreateButtons(gameManager);
            AlterFormSize(gameManager);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gameManager.Diffaculty = MinesweeperDiffaculty.Hard;
            ClearButtons(gameManager);
            gameManager.CurrentGridSize = 20;
            CreateButtons(gameManager);
            AlterFormSize(gameManager);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gameManager.Diffaculty = MinesweeperDiffaculty.Insain;
            ClearButtons(gameManager);
            gameManager.CurrentGridSize = 25;
            CreateButtons(gameManager);
            AlterFormSize(gameManager);
        }
    }
}
