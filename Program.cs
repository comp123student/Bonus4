using System;

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(123456, "John Doe", 1000.0);

        Console.Write("Enter amount to deposit: ");
        double depositAmount = double.Parse(Console.ReadLine());
        account.Deposit(depositAmount);
        Console.WriteLine($"New balance: {account.Balance:C}");

        Console.Write("Enter amount to withdraw: ");
        double withdrawAmount = double.Parse(Console.ReadLine());
        account.Withdraw(withdrawAmount);
        Console.WriteLine($"New balance: {account.Balance:C}");
    }
}
