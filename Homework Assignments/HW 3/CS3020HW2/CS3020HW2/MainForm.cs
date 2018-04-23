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
        int shim = 18;
        const int ButtonSize = 30;
        const int BufferSize = -2;
        const int TopOffset = 50;
        MinesweeperGame msGame = new MinesweeperGame(MinesweeperDifficulty.Medium);
        Button[,] gameButtons;

        #endregion

        public Hw3Form()
        {
            InitializeComponent();
        }

        #region EventMethods

        void OnMainForm_Load(object sender, EventArgs e)
        {
            CreateButtons(msGame);
        }

        void OnGameTimer_Tick(object sender, EventArgs e)
        {

        }

        #endregion

        #region HelperMethods

        void CreateButtons(MinesweeperGame mg)
        {
            // Flush the buttons and set the window size
            if (gameButtons != null)
            {
                int tmp = (int)Math.Sqrt(gameButtons.Length);
                for (int i = 0; i < tmp; i++)
                {
                    for (int j = 0; j < tmp; j++)
                    {
                        Controls.Remove(gameButtons[i, j]);
                    }
                }
            }
            gameButtons = new Button[mg.CurrentGridSize, mg.CurrentGridSize];
            Width = ((int)Math.Sqrt(gameButtons.Length) * (ButtonSize + BufferSize)) + shim;
            Height = TopOffset + ((int)Math.Sqrt(gameButtons.Length) * (ButtonSize + BufferSize)) + (3 * shim);

            // Create the buttons
            for (int i = 0; i < mg.CurrentGridSize; i++)
            {
                for (int j = 0; j < mg.CurrentGridSize; j++)
                {
                    gameButtons[i, j] = new Button
                    {
                        Size = new Size(ButtonSize, ButtonSize),
                        Left = i * (ButtonSize + BufferSize),
                        Top = (j * (ButtonSize + BufferSize)) + TopOffset,
                        Height = ButtonSize,
                        Width = ButtonSize
                };
                    gameButtons[i, j].Click += MakeAReplace;
                    gameButtons[i, j].Show();
                    Controls.Add(gameButtons[i, j]);
                }
            }
        }

        #endregion

        void MakeAReplace(object sender, EventArgs e)
        {
            ((Button)sender).Text = "H";
        }
    }
}