using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAndSolidPrinciples
{
   
    public class BaseAccount
    {
        //fields
        protected string accountNumber;
        protected decimal balance;

        //properties
        public string AccountNumber
        {
            get; set;
        }
        public decimal Balance
        {
            get; set;
        }

        //method to deposit the amount
        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        //method to withdraw the amount
        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
        }
    }

    //SavingsAccount that inherits the parent class
    public class SavingsAccount : BaseAccount
    {
        private decimal interestRate = 0.5m;

        //method to apply interest in the savings account.
        public void applyInterest()
        {
            decimal interest = balance * interestRate;
            Deposit(interest);
        }

    }
                    
}
