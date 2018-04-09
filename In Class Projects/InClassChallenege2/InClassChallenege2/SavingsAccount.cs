using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassChallenege2
{
    /// <summary>
    /// 
    /// </summary>
    public class SavingsAccount : Account
    {
        #region Fields

        readonly decimal interestRate;

        #endregion

        #region Constructors

        public SavingsAccount(decimal newInterestRate, decimal newBalance)
        {
            interestRate = newInterestRate;
            Balance = newBalance;
        }

        #endregion

        #region Properties



        #endregion

        #region Methods

        #region Public Methods

        /// <summary>
        /// Accumulate interest and deposit it into the savings account.
        /// </summary>
        public void CalculateInterest()
        {
            Credit(interestRate * Balance);
        }

        #endregion

        #region Protected Methods



        #endregion

        #region Private Methods



        #endregion

        #endregion
    }
}