using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EncapsulatedAccount
    {
        private string accountNumber;
        private decimal balance;
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
            Console.WriteLine($"Account Number: {AccountNumber} has Balance {balance} " );
      
        }
        public void Withdraw(decimal amount) {
            if(amount<=balance)
            {
                balance-=amount;
                Console.WriteLine($"The remaining balace :${balance}");
            }
            
        }


    }
}
