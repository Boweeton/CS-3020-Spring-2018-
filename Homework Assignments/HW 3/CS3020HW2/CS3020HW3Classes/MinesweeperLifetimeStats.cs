using System;
using System.Collections.Generic;
using MinesweeperGameClasses;

namespace CS3020HW3Classes
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class MinesweeperLifetimeStats
    {
        #region Fields



        #endregion

        #region Constructors



        #endregion

        #region Properties

        public List<HighScoreRecord> HighScores { get; set; } = new List<HighScoreRecord>();

        public int LifetimeWins { get; set; } = 0;

        public int LifetimeLosses { get; set; } = 0;

        public MinesweeperDifficulty LastDifficulty { get; set; } = MinesweeperDifficulty.Easy;

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

    [Serializable]
    public struct HighScoreRecord
    {
        public string name;
        public int time;
        public MinesweeperDifficulty difficulty;

        // Constructor
        public HighScoreRecord(string name, int time, MinesweeperDifficulty difficulty)
        {
            this.name = name;
            this.time = time;
            this.difficulty = difficulty;
        }
    }
}