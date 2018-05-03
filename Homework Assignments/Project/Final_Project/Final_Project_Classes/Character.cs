using System.Diagnostics;

namespace Final_Project_Classes
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("{Type}")]
    public class Character
    {
        int hitPoints;

        #region Fields



        #endregion

        #region Constructors


        public Character(CharacterType type, int strength, int intelligence, int physicalDefenseValue, int magicalDefenseValue, int hitPoints, int skillPoints, int speed)
        {
            Type = type;
            Strength = strength;
            Intelligence = intelligence;
            PhysicalDefenseValue = physicalDefenseValue;
            MagicalDefenseValue = magicalDefenseValue;
            HitPoints = hitPoints;
            SkillPoints = skillPoints;
            Speed = speed;
        }

        #endregion

        #region Properties

        public CharacterType Type { get; }

        public int Strength { get; }

        public int Intelligence { get; }

        public int PhysicalDefenseValue { get; }

        public int MagicalDefenseValue { get; }

        public int HitPoints
        {
            get => hitPoints;
            set => hitPoints = value < 0 ? 0 : value;
        }

        public int SkillPoints { get; set; }

        public int Speed { get; }

        public bool IsPhysical => Strength > Intelligence;

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