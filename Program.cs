using ConAppAss17Part1;
using System;

class Program
{
    static void Main()
    {
        BankAccount myAccount = new BankAccount("Ravula Sonali");

        Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
        Console.WriteLine($"Account Holder: {myAccount.AccountHolderName}");
        Console.WriteLine($"Initial Balance: ${myAccount.Balance}");

        myAccount.Deposit(1000);
        myAccount.Withdraw(500);

        Console.WriteLine($"Final Balance: ${myAccount.Balance}");
        Console.ReadKey();
    }
}