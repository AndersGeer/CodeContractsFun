using System;
using System.Diagnostics.Contracts;
using System.Diagnostics.Tracing;

namespace CodeContracts
{
    public class Movement
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public Movement(double amount, Account source, Account target)
        {
            Date = DateTime.Now;
            Amount = amount;
            source.Withdraw(Amount);
            target.Deposit(Amount);
            source.AddMovement(this);
            target.AddMovement(this);
        }
    }
}