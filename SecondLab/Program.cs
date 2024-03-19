using System;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("123456789", 1000.0);

        account.ShowAccountInfo();
        Console.Write("\n");

        account.Deposit(500.0);
        Console.Write("Deposited 500.0\n");

        account.ShowAccountInfo();
        Console.Write("\n");

        account.Withdraw(200.0);
        Console.Write("Withdrawn 200.0\n");

        account.ShowAccountInfo();
        Console.Write("\n");

        account.Withdraw(2000.0);
        Console.Write("Attempted to withdraw 2000.0\n");

        account.ShowAccountInfo();
        Console.ReadLine();
    }
}
