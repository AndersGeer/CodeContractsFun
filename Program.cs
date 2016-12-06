using System;
using System.Collections.Generic;

namespace CodeContracts
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Account a = new Account(-10);
            //a.Withdraw(20);
            Console.WriteLine("Account Balane: {0}", a.Balance);
            Console.ReadKey();
        }
    }
}