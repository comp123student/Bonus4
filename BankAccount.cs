using System;

public class BankAccount
{
    private double balance;

    public int AccountNumber { get; }
    public string CustomerName { get; }
    public double Balance => balance;

    public BankAccount(int accountNumber, string customerName, double balance)
    {
        AccountNumber = accountNumber;
        CustomerName = customerName;
        this.balance = balance;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException("Amount cannot be 0 nor negative");

        if (amount > balance)
            throw new ArgumentOutOfRangeException("Amount cannot be greater than the Balance");

        balance -= amount;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException("Amount cannot be 0 nor negative");

        balance += amount;
    }
}
