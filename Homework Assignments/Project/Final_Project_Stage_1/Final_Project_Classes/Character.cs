using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Project_Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class Character
    {
        #region Fields



        #endregion

        #region Constructors

        public Character()
        {
        }

        #endregion

        #region Properties

        public string Name { get; set; }

        public int Strength { get; set; }

        public int Intelligence { get; set; }

        public int PhysicalAttackPower { get; set; }

        public int MagicalAttackPower { get; set; }

        public int PhysicalDefenseValue { get; set; }

        public int MagicalDefenseValue { get; set; }

        public int HitPoints { get; set; }

        public int SkillPoints { get; set; }

        public int Speed { get; set; }

        #endregion

        #region Methods

        #region Public Methods

        public void Attack(Character ch)
        {

        }

        public void SpecialAction(Character ch)
        {

        }

        #endregion

        #region Protected Methods



        #endregion

        #region Private Methods



        #endregion

        #endregion
    }
}