using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinesweeperGameClasses
{
    /// <summary>
    /// 
    /// </summary>
    public class MinesweeperGameManager
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

        public MinesweeperGameManager (MinesweeperDiffaculty newDiffaculty)
        {
            Diffaculty = newDiffaculty;
        }

        #endregion

        #region Properties

        public MinesweeperDiffaculty Diffaculty { get; set; }

        public GridCell[,] Cells { get; set; } = new GridCell[EasyGridSize, EasyGridSize];

        public int CurrentGridSize { get; set; }

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
                    bool tmpBool = rng.NextDouble() <= localFrequency;
                    Cells[i, j] = new GridCell(tmpBool);
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