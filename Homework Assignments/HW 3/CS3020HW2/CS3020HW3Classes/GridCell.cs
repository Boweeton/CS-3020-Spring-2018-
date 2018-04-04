using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperGameClasses
{
    public class GridCell
    {
        #region Fields



        #endregion

        #region Constructors

        public GridCell (bool newHasMineValue)
        {
            HasMine = newHasMineValue;
        }

        #endregion

        #region Properties

        public bool HasMine { get; set; }

        #endregion

        #region Methods



        #endregion
    }
}