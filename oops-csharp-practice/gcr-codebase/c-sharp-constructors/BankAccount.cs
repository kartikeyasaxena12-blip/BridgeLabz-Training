using System;

class BankAccount
{
    // Access modifiers
    public int accountNumber;
    protected string accountHolder;
    private double balance;

    // Constructor
    public BankAccount(int accountNumber, string accountHolder, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Insufficient balance or invalid amount.");
    }

    public void DisplayAccount()
    {
        Console.WriteLine("Account Number  : " + accountNumber);
        Console.WriteLine("Account Holder  : " + accountHolder);
        Console.WriteLine("Balance         : " + balance);
    }
}

// Subclass
class SavingsAccount : BankAccount
{
    double interestRate;

    public SavingsAccount(int accountNumber, string accountHolder, double balance, double interestRate)
        : base(accountNumber, accountHolder, balance)
    {
        this.interestRate = interestRate;
    }

    public void DisplaySavingsAccount()
    {
        Console.WriteLine("Account Number : " + accountNumber);
        Console.WriteLine("Account Holder : " + accountHolder);

        Console.WriteLine("Balance        : " + GetBalance());
        Console.WriteLine("Interest Rate  : " + interestRate + "%");
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount(12345, "Rahul", 5000);
        acc.DisplayAccount();

        Console.WriteLine();

        // Modify balance
        acc.Deposit(2000);
        acc.Withdraw(1000);
        Console.WriteLine("Updated Balance: " + acc.GetBalance());

        Console.WriteLine();

        SavingsAccount sa = new SavingsAccount(67890, "Neha", 10000, 4.5);
        sa.DisplaySavingsAccount();
    }
}
