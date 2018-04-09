using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassChallenege2
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckingAccount : Account
    {
        #region Fields

        readonly decimal feeChargedPerTransaction;

        #endregion

        #region Constructors

        public CheckingAccount(decimal newFeeChargedPerTransaction, decimal newBalance)
        {
            feeChargedPerTransaction = newFeeChargedPerTransaction;
            Balance = newBalance;
        }

        #endregion

        #region Properties



        #endregion

        #region Methods

        #region Public Methods

        /// <summary>
        /// Deposits money into account, then subtracts the fee.
        /// </summary>
        /// <param name="amountToBeDeposited">The amount to be deposited.</param>
        public override void Credit(decimal amountToBeDeposited)
        {
            // Check for negative input
            if (amountToBeDeposited < 0.0m)
            {
                Console.WriteLine("Cannot deposit negative amount.");
                return;
            }

            Balance += amountToBeDeposited;
            Balance -= feeChargedPerTransaction;
        }

        /// <summary>
        /// Withdraws money from the account, then subtracts the fee.
        /// </summary>
        /// <param name="amountToBeWithdrawn">The amount to be withdrawn.</param>
        public override void Debit(decimal amountToBeWithdrawn)
        {
            // Check for negative input
            if (amountToBeWithdrawn < 0.0m)
            {
                Console.WriteLine("Cannot withdraw negative amount.");
                return;
            }

            // Check for overdraw
            if (amountToBeWithdrawn > Balance + feeChargedPerTransaction)
            {
                Console.WriteLine("Debit amount excedes account balance and transaction fee.");
            }
            else
            {
                Balance -= amountToBeWithdrawn;
                if (amountToBeWithdrawn == 0.0m)
                {
                    Balance -= feeChargedPerTransaction;
                }
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