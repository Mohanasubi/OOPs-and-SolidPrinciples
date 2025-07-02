
using ConsoleApp1;

//Encapsulation

EncapsulatedAccount myAccount = new EncapsulatedAccount();
myAccount.AccountNumber = "12345676465";
myAccount.Deposit(1000);
myAccount.Withdraw(500);
Console.WriteLine("Account Number: " + myAccount.AccountNumber);
Console.WriteLine("Balance: $" + myAccount.Balance);

//Inheritance

SavingsAccount savingsAccount = new SavingsAccount();
savingsAccount.AccountNumber = "12389740867";
savingsAccount.Deposit(1000);
savingsAccount.applyInterest();

//polymorphism

//overridden 
PaymentMethod paymentMethod = new PaymentMethod();
paymentMethod.processPayment(1000);

paymentMethod = new CreditCardPayment();
paymentMethod.processPayment(2000);

paymentMethod=new BanktransferPayment();
paymentMethod.processPayment(3000);

//overloaded
PaymentMethod overloadingMethod = new PaymentMethod();
paymentMethod.processPayment(4000, "Credit Card");
paymentMethod.processPayment(3000,"UPI",DateTime.Now);


//Abstraction
Document pdfDocument = new PdfDocument("report.pdf");
pdfDocument.open();
pdfDocument.readContent();
pdfDocument.print();


Document wordDocument = new WordDocument("report.docx");
wordDocument.open();
wordDocument.readContent();
wordDocument.print();


