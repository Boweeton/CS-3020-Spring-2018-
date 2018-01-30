using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SODERSTROM_HW_1
{
    class Boat
    {
        #region Fields



        #endregion

        #region Constructors

        public Boat(int newLength)
        {
            Length = newLength;
        }

        #endregion

        #region Properties

        public bool IsDestroyed { get; set; }
        public int Length { get; set; }
        public List<Pair2D> CoordinatesOwned { get; } = new List<Pair2D>();
        public BoatDirection Direction { get; set; }

        #endregion

        #region Methods



        #endregion
    }
}
