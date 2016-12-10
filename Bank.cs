using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CodeContracts
{
    public class Bank
    {
        public string Name { get; set; }

        private List<Customer> _customers;
        private List<Account> _accounts;

        public Bank(string name)
        {
            Name = name;
            _customers = new List<Customer>();
            _accounts = new List<Account>();
        }

        public void AddCustomer(Customer cust)
        {
            _customers.Add(cust);
        }

        public Customer GetCustomer(int id)
        {
            return _customers.Find((cust) => cust.Id == id);
        }

        public void RemoveCustomer(int id)
        {
            var cust = GetCustomer(id);
            _customers.Remove(cust);
        }

        public List<Customer> GetCustomers()
        {
            return _customers;
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

        public void Move(double amount, Account source, Account target)
        {
            new Movement(amount, source, target);
        }

        public void MakeStatement(Customer cust, Account acc)
        {
            AddCustomer(cust);
            AddAccount(acc);
        }
    }
}