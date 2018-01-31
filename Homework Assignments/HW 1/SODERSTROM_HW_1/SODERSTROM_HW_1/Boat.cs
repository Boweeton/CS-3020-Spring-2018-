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

        public void TakeOwnershipOfPairs(int baseX, int baseY, int endX, int endY)
        {
            // Local declarations
            Pair2D tmpPair;

            // Loop through the given coordinates and make the boat take ownership of them (get it.... ownerSHIP???)
            for (int i = baseX; i <= endX; i++)
            {
                for (int j = baseY; j <= endY; j++)
                {
                    tmpPair = new Pair2D(i, j);
                    CoordinatesOwned.Add(tmpPair);
                }
            }
        }

        #endregion
    }
}
