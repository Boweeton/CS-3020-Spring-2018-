using System.Collections.Generic;
using CS3020HW2;

namespace MinesweeperGameClasses
{
    public class GridCell
    {
        #region Fields



        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public GridCell(int x, int j)
        {
            I = x;
            J = j;
        }

        #endregion

        #region Properties

        public bool HasMine { get; set; }

        public bool HasBeenClicked { get; set; } = false;

        public GameImage Image { get; set; }

        public int AdjMineCount { get; set; } = 0;

        public List<GridCell> Neighbors { get; set; } = new List<GridCell>();

        public int I { get; set; }
        public int J { get; set; }

        //public Button CellButton { get; set; }


        #endregion

        #region Methods

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"mine: {HasMine}//image: {Image}";
        }

        #endregion
    }
}