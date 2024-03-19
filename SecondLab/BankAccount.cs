using System;

class BankAccount
{
    private readonly string accountNumber;
    private double balance;

    public BankAccount(string accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public bool Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            return true;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
            return false;
        }
    }

    public void ShowAccountInfo()
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Balance: {balance}");
    }
}
