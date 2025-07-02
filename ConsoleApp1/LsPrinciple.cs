using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAndSolidPrinciples
{
    namespace LSPDemo
    {
        // Base class: BankAccount
        public class BankAccount
        {
            //properties
            public string AccountNumber { get; set; }
            public decimal Balance { get; set; }

            //constructor
            public BankAccount(string accountNumber, decimal balance)
            {
                AccountNumber = accountNumber;
                Balance = balance;
            }

            //method to deposit the amount and calculate total balance
            public virtual void DepositAndCalculateTotalBalance(decimal amount)
            {
                Balance += amount;
                Console.WriteLine($"Deposit: {amount}, Total Amount: {Balance}");
            }
            //method to withdraw amount from the bank account
            public virtual void WithdrawAmount(decimal amount)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
        }

        // Derived class: SavingsAccount
        public class SavingsAccount : BankAccount
        {
            public decimal InterestRate { get; set; }

            //constructors
            public SavingsAccount(string accountNumber, decimal balance, decimal interestRate)
                : base(accountNumber, balance)
            {
                InterestRate = interestRate;
            }

            //method to withdraw amount from the account and calculate total balance
            public override void WithdrawAmount(decimal amount)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"AccountNumber: {AccountNumber}, Withdraw: {amount}, Balance: {Balance}");
                }
                else
                {
                    Console.WriteLine($"AccountNumber: {AccountNumber}, Withdraw: {amount}, Insufficient Funds, Available Funds: {Balance}");
                }
            }
        }

        // Derived class: CurrentAccount
        public class CurrentAccount : BankAccount
        {
            public decimal OverdraftLimit { get; set; }

            //constructors
            public CurrentAccount(string accountNumber, decimal balance, decimal overdraftLimit)
                : base(accountNumber, balance)
            {
                OverdraftLimit = overdraftLimit;
            }
            //method to withdraw amount from the current account
            public override void WithdrawAmount(decimal amount)
            {
                if (amount <= Balance + OverdraftLimit)
                {
                    Balance -= amount;
                    Console.WriteLine($"AccountNumber: {AccountNumber}, Withdraw: {amount}, Balance: {Balance}");
                }
                else
                {
                    Console.WriteLine($"AccountNumber: {AccountNumber}, Exceeded Overdraft Limit.");
                }
            }
        }

    }
}

