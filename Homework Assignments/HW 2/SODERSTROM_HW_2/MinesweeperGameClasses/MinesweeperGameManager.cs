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

        GridCell[,] cells = new GridCell[EasyGridSize, EasyGridSize];

        #endregion

        #region Constructors

        public MinesweeperGameManager (MinesweeperDiffaculty newDiffaculty)
        {
            diffaculty = newDiffaculty;
        }

        #endregion

        #region Properties

        public MinesweeperDiffaculty diffaculty { get; set; }

        #endregion

        #region Methods

        #region Public Methods

        /// <summary>
        /// Generates the board according to the current game diffaculty.
        /// </summary>
        public void InitializeBoard()
        {
            // Set the board size and mine frequency
            int localGridSize;
            double localFrequency;
            switch (diffaculty)
            {
                case MinesweeperDiffaculty.Easy:
                    localGridSize = EasyGridSize;
                    localFrequency = EasyMineFrequency;
                    break;

                case MinesweeperDiffaculty.Medium:
                    localGridSize = MediumGridSize;
                    localFrequency = MediumMineFrequency;
                    break;

                case MinesweeperDiffaculty.Hard:
                    localGridSize = HardGridSize;
                    localFrequency = HardMineFrequency;
                    break;

                case MinesweeperDiffaculty.Insain:
                    localGridSize = InsainGridSize;
                    localFrequency = InsainMineFrequency;
                    break;

                default:
                    localGridSize = 0;
                    localFrequency = 1;
                    break;
            }

            // Create the new board Grid
            cells = new GridCell[localGridSize, localGridSize];

            // Populate the Grid with initialized GridCell objects
            for (int i = 0; i < cells.Length; i++)
            {
                for (int j = 0; j < cells.Length; j++)
                {
                    bool tmpBool = rng.NextDouble() <= localFrequency;
                    cells[i, j] = new GridCell(tmpBool);
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