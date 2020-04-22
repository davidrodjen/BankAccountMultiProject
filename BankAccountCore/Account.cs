using System;

namespace BankAccountCore
{

    /// <summary>
    /// represents an individual bank account
    /// </summary>
    public class Account
    {
        public Account(double initialBalance)
        {
            Balance = initialBalance;
        }

        /// <summary>
        /// The current balance of the account
        /// </summary>
        public double Balance { get; private set; }

        /// <summary>
        /// Deposits money into account
        /// </summary>
        /// <param name="amt">The amount to deposit</param>
        public void Deposit(double amt)
        {
            Balance += amt;
        }

        /// <summary>
        /// Get current balance displayed as currency
        /// </summary>
        /// <returns></returns>
        public string GetBalanceDisplay()
        {
            return Balance.ToString("c");
        }
    }
}
