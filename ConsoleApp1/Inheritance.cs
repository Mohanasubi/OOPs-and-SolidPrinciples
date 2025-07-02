using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BaseAccount
    {
        protected string accountNumber;
        protected decimal balance;
        public String AccountNumber
        {
            get; set;
        }
        public decimal Balance
        {
            get; set;
        }
        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
        }
    }

    public class SavingsAccount : BaseAccount
    {
        private decimal interestRate = 0.5m;

        public void applyInterest()
        {
            decimal interest = balance * interestRate;
            Deposit(interest);
        }

    }
                    
}
