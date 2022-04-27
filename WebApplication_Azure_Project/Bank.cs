using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Azure_Project
{
    public class Bank
    {
        private string name { set; get; }
        private List<Account> accounts = new List<Account>();

        public Bank(string name)
        {
            this.name = name;
        }

        public void addNewAccount(string name, int accountNumber)
        {
            accounts.Add(new Account(name, accountNumber));
        }

        public void deposit(int accountNumber, double amount)
        {
            foreach (Account account in accounts)
            {
                if (account.getAccountNumber() == accountNumber)
                {
                    account.deposit(amount);
                }
            }
        }

        public double getAccountBalance(int accountNumber)
        {

            foreach (Account account in accounts)
            {
                if (account.getAccountNumber() == accountNumber)
                {
                    return account.getBalance(); ;
                }
            }

            return 0;
        }
    }
}
