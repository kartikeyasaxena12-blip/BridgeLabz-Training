using System;

// Interface for loan facility
interface ILoanable
{
    void ApplyForLoan(double amount);
    double CalculateLoanEligibility();
}

// Abstract BankAccount class
abstract class BankAccount
{
    protected int accountNumber;
    protected string holderName;
    protected double balance;

    private string pin;

    public void SetAccountNumber(int number)
    {
        accountNumber = number;
    }

    public void SetHolderName(string name)
    {
        holderName = name;
    }

    public void SetInitialBalance(double amount)
    {
        balance = amount;
    }

    public void SetPIN(string userPin)
    {
        pin = userPin;
    }

    // Deposit money
    public void Deposit(double amount)
    {
        balance += amount;
    }

    // Withdraw money
    public void Withdraw(double amount)
    {
        if (amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Insufficient balance");
    }

    public abstract double CalculateInterest();

    // display
    public void DisplayAccount()
    {
        Console.WriteLine("Account No : " + accountNumber);
        Console.WriteLine("Holder    : " + holderName);
        Console.WriteLine("Balance   : " + balance);
    }
}

// Savings Account
class SavingsAccount : BankAccount, ILoanable
{
    public override double CalculateInterest()
    {
        return balance * 0.04;
    }

    public void ApplyForLoan(double amount)
    {
        Console.WriteLine("Savings Account Loan Applied: " + amount);
    }

    public double CalculateLoanEligibility()
    {
        return balance * 5; 
    }
}

// Current Account
class CurrentAccount : BankAccount
{
    public override double CalculateInterest()
    {
        return balance * 0.01; 
    }
}

// Main Program
class Program
{
    static void PrintAccountDetails(BankAccount account)
    {
        double interest = account.CalculateInterest();

        account.DisplayAccount();
        Console.WriteLine("Interest  : " + interest);

        if (account is ILoanable)
        {
            ILoanable loanAccount = (ILoanable)account;
            Console.WriteLine("Loan Eligibility: " + loanAccount.CalculateLoanEligibility());
        }

        Console.WriteLine("-------------------");
    }

    static void Main()
    {
        BankAccount acc1 = new SavingsAccount();
        acc1.SetAccountNumber(1001);
        acc1.SetHolderName("Amit");
        acc1.SetInitialBalance(50000);
        acc1.SetPIN("1234");

        BankAccount acc2 = new CurrentAccount();
        acc2.SetAccountNumber(1002);
        acc2.SetHolderName("Riya");
        acc2.SetInitialBalance(80000);
        acc2.SetPIN("5678");

        BankAccount[] accounts = { acc1, acc2 };

        foreach (BankAccount acc in accounts)
        {
            PrintAccountDetails(acc); // polymorphism
        }
    }
}
