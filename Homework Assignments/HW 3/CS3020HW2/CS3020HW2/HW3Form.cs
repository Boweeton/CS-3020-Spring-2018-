using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS3020HW3Classes;
using MinesweeperGameClasses;

namespace CS3020HW2
{
    public partial class Hw3Form : Form
    {
        #region ClassLevelDeclarations

        int seconds = 60;
        const int ButtonSize = 30;
        const int BufferSize = 0;
        const int TopOffset = 50;
        MinesweeperGame msGame = new MinesweeperGame(MinesweeperDiffaculty.Easy);
        Button[,] gameButtons;

        #endregion

        public Hw3Form()
        {
            InitializeComponent();
        }

        #region EventMethods

        void OnHw3FormLoad(object sender, EventArgs e)
        {
            CreateButtons(msGame);
        }

        void OnGameTimerTick(object sender, EventArgs e)
        {

        }

        #endregion

        #region HelperMethods

        void CreateButtons(MinesweeperGame MG)
        {
            // Create the buttons
            for (int i = 0; i < MG.CurrentGridSize; i++)
            {
                for (int j = 0; j < MG.CurrentGridSize; j++)
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

        #endregion
    }
}
