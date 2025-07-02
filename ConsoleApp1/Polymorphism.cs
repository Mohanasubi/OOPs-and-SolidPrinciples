using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAndSolidPrinciples
{
   
    public class PaymentMethod
    {
        //overriding method
        public  virtual void processPayment(decimal amount) {
            Console.WriteLine($"The amount {amount} is credited.");
        }


        //overloading method

        public  void processPayment(decimal amount, string method)
        {
            Console.WriteLine($"The amount {amount} is credited by {method}");
        }
        public void processPayment(decimal amount, string method, DateTime date)
        {
            Console.WriteLine($"The amount {amount} is credited by {method} on {date} ");
        }
    }

    //creditcardpayment class 
    public class CreditCardPayment : PaymentMethod
    {
        //method that overides the processPayment
        public override void processPayment(decimal amount)
        {
            Console.WriteLine($"The amount {amount} is credited using credit card");
        }
    }

    public class BanktransferPayment : PaymentMethod {
        public override void processPayment(decimal amount)
        {
            Console.WriteLine($"The amount {amount} is credited by bank transfer method");
        }
    }
}
