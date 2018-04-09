using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassChallenege2
{
    /// <summary>
    /// 
    /// </summary>
    public class Account
    {
        #region Fields



        #endregion

        #region Constructors

        public Account()
        {
            Balance = (decimal)0.0;
        }

        public Account(decimal initialBalance)
        {
            if (initialBalance >= (decimal)0.0)
            {
                Balance = initialBalance;
            }
            else
            {
                throw new Exception("Initial balance is less than zero");
            }
        }

        #endregion

        #region Properties

        public decimal Balance { get; set; }

        #endregion

        #region Methods

        #region Public Methods

        /// <summary>
        /// Deposits money into account.
        /// </summary>
        /// <param name="amountToBeDeposited">The amount to be deposited.</param>
        public virtual void Credit(decimal amountToBeDeposited)
        {
            // Check for negative input
            if (amountToBeDeposited < 0.0m)
            {
                Console.WriteLine("Cannot deposit negative amount.");
                return;
            }

            Balance += amountToBeDeposited;
        }

        /// <summary>
        /// Withdraws money from the account.
        /// </summary>
        /// <param name="amountToBeWithdrawn">The amount to be withdrawn.</param>
        public virtual void Debit(decimal amountToBeWithdrawn)
        {
            // Check for negative input
            if (amountToBeWithdrawn < 0.0m)
            {
                Console.WriteLine("Cannot withdraw negative amount.");
                return;
            }

            // Check for overdraw
            if (amountToBeWithdrawn > Balance)
            {
                Console.WriteLine("Debit amount excedes account balance");
            }
            else
            {
                Balance -= amountToBeWithdrawn;
            }
        }

        #endregion

        #region Protected Methods



        #endregion

        #region Private Methods



        #endregion

        #endregion
    }
}