using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MinesweeperGameClasses;

namespace CS3020HW3Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class MinesweeperButton : Button
    {
        #region Fields



        #endregion

        #region Constructors

        public MinesweeperButton(GridCell cell)
        {
            Cell = cell;
        }

        #endregion

        #region Properties

        public bool IsFlagged { get; set; }

        public GridCell Cell { get; set; }

        #endregion

        #region Methods

        #region Public Methods



        #endregion

        #region Protected Methods



        #endregion

        #region Private Methods



        #endregion

        #endregion
    }
}