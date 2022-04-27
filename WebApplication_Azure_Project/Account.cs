using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Azure_Project
{
    public class Account
    {
        private string personName { set; get; }
        private int accountNumber { set; get; }

        private double balance = 0;

        public Account(string personName, int accountNumber)
        {
            this.personName = personName;
            this.accountNumber = accountNumber;
        }

        public void deposit(double amount)
        {
            this.balance += amount;
        }

        public double getBalance()
        {
            return balance;
        }

        public double getAccountNumber()
        {
            return accountNumber;

        }
