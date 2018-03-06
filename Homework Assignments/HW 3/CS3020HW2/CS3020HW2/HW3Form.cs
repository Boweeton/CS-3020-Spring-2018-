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

namespace CS3020HW2
{
    public partial class Hw3Form : Form
    {
        #region ClassLevelDeclarations

        int seconds = 60;
        const int ButtonSize = 30;
        const int BufferSize = 0;
        const int TopOffset = 50;
        MinesweeperGame msGame = new MinesweeperGame();
        Button[,] gameButtons;

        #endregion

        public Hw3Form()
        {
            InitializeComponent();
        }

        #region EventMethods

        void OnHw3FormLoad(object sender, EventArgs e)
        {

        }

        void OnGameTimerTick(object sender, EventArgs e)
        {

        }

        #endregion

        #region HelperMethods



        #endregion
    }
}
