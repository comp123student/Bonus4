using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class BankAppTests
{
    private readonly string ownerName = "Amber Malik";

    [TestMethod]
    [TestCategory("Important")]
    public void Deposit_ValidAmount_UpdatesBalance()
    {
        BankAccount account = new BankAccount(123456, "John Doe", 1000.0);
        double depositAmount = 500.0;

        account.Deposit(depositAmount);

        Assert.AreEqual(1500.0, account.Balance);
    }

    [TestMethod]
    [TestCategory("Important")]
    public void Withdraw_ValidAmount_UpdatesBalance()
    {
        BankAccount account = new BankAccount(123456, "John Doe", 1000.0);
        double withdrawAmount = 500.0;

        account.Withdraw(withdrawAmount);

        Assert.AreEqual(500.0, account.Balance);
    }

    [TestMethod]
    [TestCategory("Very Important")]
    public void Withdraw_AmountGreaterThanBalance_ThrowsException()
    {
        BankAccount account = new BankAccount(123456, "John Doe", 1000.0);
        double withdrawAmount = 1500.0;

        Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Withdraw(withdrawAmount));
    }

    [TestMethod]
    [TestCategory("Very Important")]
    public void Withdraw_ZeroOrNegativeAmount_ThrowsException()
    {
        BankAccount account = new BankAccount(123456, "John Doe", 1000.0);
        double withdrawAmount = -100.0;

        Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Withdraw(withdrawAmount));
    }

    [TestMethod]
    [TestCategory("Very Important")]
    public void Deposit_ZeroOrNegativeAmount_ThrowsException()
    {
        BankAccount account = new BankAccount(123456, "John Doe", 1000.0);
        double depositAmount = 0.0;

        Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Deposit(depositAmount));
    }
}
