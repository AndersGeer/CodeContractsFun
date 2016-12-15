using System.Collections.Generic;

namespace CodeContracts
{
    public class Customer
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        private List<Account> _accounts;

        protected internal Customer(string name)
        {
            Id = _id++;
            Name = name;
            _accounts = new List<Account>();
        }

        public void AddAccount(Account acc)
        {
            _accounts.Add(acc);
        }

        public Account GetAccount(int number)
        {
            return _accounts.Find((acc) => acc.Number == number);
        }

        public void DeleteAccount(int number)
        {
            Account acc = GetAccount(number);
            _accounts.Remove(acc);
        }

        public List<Account> GetAccounts()
        {
            return _accounts;
        }

    }
}