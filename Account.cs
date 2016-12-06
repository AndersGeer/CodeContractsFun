
using System;
using System.Diagnostics.Contracts;

namespace CodeContracts
{
    public class Account
    {
        public int Balance { get; set; }

        /// <summary>
        /// This method is supposed to run on every method call.
        /// Currently doesn't work at all. Even if it's a copy of a working one
        /// </summary>
        [ContractInvariantMethod]
        private void CheckBalance()
        {
            Contract.Invariant(Balance >= 0);
        }

        /// <summary>
        /// Constructor with a balance added as parameter
        /// </summary>
        /// <param name="balance"></param>
        public Account(int balance)
        {
            //Acts as invariant for non-working invariant
            Contract.Requires<ArgumentException>(balance > 0, "Exception");
            Balance = balance;
        }

        /// <summary>
        /// Deposit function for account
        /// pre conditions with param more than 0.
        /// Ensures added balance and result being more than 0
        /// </summary>
        /// <param name="balance"></param>
        public void Deposit(int balance)
        {
            Contract.Requires(balance > 0, "Amount to deposit must be more than 0");
            Contract.Requires<ArgumentException>(balance > 0, "Exception");

            Contract.Ensures(Contract.Result<int>() > Contract.OldValue(Balance));
            Contract.Ensures(Contract.Result<int>() > 0);

            Balance += balance;
        }

        /// <summary>
        /// Withdraw function for account
        /// pre conditions with param more than 0.
        /// Ensures withdrawn balance and result being more than 0
        /// </summary>
        /// <param name="balance"></param>
        public void Withdraw(int balance)
        {
            Contract.Requires(balance > 0, "Amount to withdraw must be more than 0");
            Contract.Requires(balance < Balance);
            Contract.Requires<ArgumentException>(balance > 0, "Exception");
            Contract.Requires<ArgumentException>(balance > Balance, "Exception");

            Contract.Ensures(Contract.Result<int>() > 0);
            Contract.Ensures(Contract.Result<double>() < Contract.OldValue(Balance));

            Balance -= balance;
        }


    }
}