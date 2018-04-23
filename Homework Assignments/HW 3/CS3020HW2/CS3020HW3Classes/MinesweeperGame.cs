using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinesweeperGameClasses;

namespace CS3020HW3Classes
{
    public class MinesweeperGame
    {
        #region Fields

        Random rng = new Random();

        const int EasyGridSize = 10;
        const int MediumGridSize = 15;
        const int HardGridSize = 20;
        const int InsainGridSize = 25;

        const double EasyMineFrequency = 0.25;
        const double MediumMineFrequency = 0.45;
        const double HardMineFrequency = 0.65;
        const double InsainMineFrequency = 0.85;

        #endregion

        #region Constructors

        public MinesweeperGame(MinesweeperDifficulty newDiffaculty)
        {
            Diffaculty = newDiffaculty;
            InitializeBoard();
        }

        #endregion

        #region Properties

        public MinesweeperDifficulty Diffaculty { get; set; }

        public int CurrentGridSize { get; set; }

        public GridCell[,] Cells { get; set; }

        #endregion

        #region Methods

        #region Public Methods

        /// <summary>
        /// Generates the board according to the current game diffaculty.
        /// </summary>
        public void InitializeBoard()
        {
            // Set the board size and mine frequency
            double localFrequency;
            switch (Diffaculty)
            {
                case MinesweeperDiffaculty.Easy:
                    CurrentGridSize = EasyGridSize;
                    localFrequency = EasyMineFrequency;
                    break;

                case MinesweeperDiffaculty.Medium:
                    CurrentGridSize = MediumGridSize;
                    localFrequency = MediumMineFrequency;
                    break;

                case MinesweeperDiffaculty.Hard:
                    CurrentGridSize = HardGridSize;
                    localFrequency = HardMineFrequency;
                    break;

                case MinesweeperDiffaculty.Insain:
                    CurrentGridSize = InsainGridSize;
                    localFrequency = InsainMineFrequency;
                    break;

                default:
                    CurrentGridSize = 0;
                    localFrequency = 1;
                    break;
            }

            // Create the new board Grid
            Cells = new GridCell[CurrentGridSize, CurrentGridSize];

            // Populate the Grid with initialized GridCell objects
            for (int i = 0; i < CurrentGridSize; i++)
            {
                for (int j = 0; j < CurrentGridSize; j++)
                {
                    bool tmpVal = rng.NextDouble() <= localFrequency;
                    Cells[i, j] = new GridCell(tmpVal);
                }
            }
        }

        #endregion

        #region Protected Methods



        #endregion

        #region Private Methods



        #endregion

        #endregion
    }
}
