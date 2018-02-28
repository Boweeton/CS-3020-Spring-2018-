using MinesweeperGameClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SODERSTROM_HW_2
{
    public partial class MinesweeperMainForm : Form
    {
        #region ClassLevelDeclarations

        MinesweeperGameManager gameManager = new MinesweeperGameManager(MinesweeperDiffaculty.Easy);

        #endregion

        public MinesweeperMainForm()
        {
            InitializeComponent();
        }

        #region Events
        
        private void OnMinesweeperMainFormLoad (object sender, EventArgs e)
        {
            CreateButtons();
        }

        #endregion

        #region HelperMethods

        void CreateButtons ()
        {

        }

        #endregion
    }
}
