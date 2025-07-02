using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAndSolidPrinciples
{
    //Single Responsibility Priciple

    //interfaces for bankaccount and interest calculator
    public interface IBankAccount
    {
        string AccountNumber { get; set; }
        decimal AccountBalance { get; set; }
    }


    public interface IInterstCalculator
    {
        decimal CalculateInterest();
    }

    //Bank Account class that stores only the fields 
    public class BankAccount : IBankAccount
    {
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
    }

    //class to calculate the interest

    public class InterstCalculator : IInterstCalculator
    {
        public decimal CalculateInterest(IBankAccount account)
        {

            return 1000;
        }

        public decimal CalculateInterest()
        {
            throw new NotImplementedException();
        }
    }
}

