using System;
using CS3020HW2;
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

        const double EasyMineFrequency = 0.12;
        const double MediumMineFrequency = 0.18;
        const double HardMineFrequency = 0.22;
        const double InsainMineFrequency = 0.30;

        #endregion

        #region Constructors

        public MinesweeperGame(MinesweeperDifficulty newDiffaculty)
        {
            Diffaculty = newDiffaculty;
            InitializeBoard(Diffaculty);
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
        public void InitializeBoard(MinesweeperDifficulty newDifficulty)
        {
            Diffaculty = newDifficulty;

            // Set the board size and mine frequency
            double localFrequency;
            switch (Diffaculty)
            {
                case MinesweeperDifficulty.Easy:
                    CurrentGridSize = EasyGridSize;
                    localFrequency = EasyMineFrequency;
                    break;

                case MinesweeperDifficulty.Medium:
                    CurrentGridSize = MediumGridSize;
                    localFrequency = MediumMineFrequency;
                    break;

                case MinesweeperDifficulty.Hard:
                    CurrentGridSize = HardGridSize;
                    localFrequency = HardMineFrequency;
                    break;

                case MinesweeperDifficulty.Insain:
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

            for (int i = 0; i < CurrentGridSize; i++)
            {
                for (int j = 0; j < CurrentGridSize; j++)
                {
                    Cells[i,j] = new GridCell(i,j);
                }
            }

            // Populate with mines and increment
            for (int i = 0; i < CurrentGridSize; i++)
            {
                for (int j = 0; j < CurrentGridSize; j++)
                {
                    Cells[i, j].HasMine = rng.NextDouble() <= localFrequency;


                    if (i - 1 >= 0 && i - 1 <= CurrentGridSize - 1 && j - 1 >= 0 && j - 1 <= CurrentGridSize - 1)
                    {
                        if (Cells[i, j].HasMine)
                        {
                            Cells[i - 1, j - 1].AdjMineCount++;
                        }
                        Cells[i, j].Neighbors.Add(Cells[i - 1, j - 1]);
                    }


                    if (j - 1 >= 0 && j - 1 <= CurrentGridSize - 1)
                    {
                        if (Cells[i, j].HasMine)
                        {
                            Cells[i, j - 1].AdjMineCount++;
                        }
                        Cells[i, j].Neighbors.Add(Cells[i, j - 1]);
                    }


                    if (i + 1 >= 0 && i + 1 <= CurrentGridSize - 1 && j - 1 >= 0 && j - 1 <= CurrentGridSize - 1)
                    {
                        if (Cells[i, j].HasMine)
                        {
                            Cells[i + 1, j - 1].AdjMineCount++;
                        }
                        Cells[i, j].Neighbors.Add(Cells[i + 1, j - 1]);
                    }


                    if (i - 1 >= 0 && i - 1 <= CurrentGridSize - 1)
                    {
                        if (Cells[i, j].HasMine)
                        {
                            Cells[i - 1, j].AdjMineCount++;
                        }
                        Cells[i, j].Neighbors.Add(Cells[i - 1, j]);
                    }


                    if (i + 1 >= 0 && i + 1 <= CurrentGridSize - 1)
                    {
                        if (Cells[i, j].HasMine)
                        {
                            Cells[i + 1, j].AdjMineCount++;
                        }
                        Cells[i, j].Neighbors.Add(Cells[i + 1, j]);
                    }


                    if (i - 1 >= 0 && i - 1 <= CurrentGridSize - 1 && j + 1 >= 0 && j + 1 <= CurrentGridSize - 1)
                    {
                        if (Cells[i, j].HasMine)
                        {
                            Cells[i - 1, j + 1].AdjMineCount++;
                        }
                        Cells[i, j].Neighbors.Add(Cells[i - 1, j + 1]);
                    }


                    if (j + 1 >= 0 && j + 1 <= CurrentGridSize - 1)
                    {
                        if (Cells[i, j].HasMine)
                        {
                            Cells[i, j + 1].AdjMineCount++;
                        }
                        Cells[i, j].Neighbors.Add(Cells[i, j + 1]);
                    }


                    if (i + 1 >= 0 && i + 1 <= CurrentGridSize - 1 && j + 1 >= 0 && j + 1 <= CurrentGridSize - 1)
                    {
                        if (Cells[i, j].HasMine)
                        {
                            Cells[i + 1, j + 1].AdjMineCount++;
                        }
                        Cells[i,j].Neighbors.Add(Cells[i + 1, j + 1]);
                    }
                }
            }

            // Set the rest of the images
            for (int i = 0; i < CurrentGridSize; i++)
            {
                for (int j = 0; j < CurrentGridSize; j++)
                {
                    Cells[i, j].Image = Cells[i, j].HasMine ? GameImage.Mine : (GameImage)Cells[i, j].AdjMineCount;
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
