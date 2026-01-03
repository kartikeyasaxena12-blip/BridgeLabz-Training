using System;

class BankAccount
{
    // static variable 
    public static string bankName = "HDFC Bank";
    private static int totalAccounts = 0;

    // readonly variable
    public readonly int AccountNumber;

    // instance variable
    public string AccountHolderName;

    // Constructor
    public BankAccount(string AccountHolderName, int AccountNumber)
    {
        this.AccountHolderName = AccountHolderName;
        this.AccountNumber = AccountNumber;

        totalAccounts++;
    }

    // static method
    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    // method to display account details
    public void DisplayDetails(object obj)
    {
        // using is operator
        if (obj is BankAccount)
        {
            Console.WriteLine("Bank Name: " + bankName);
            Console.WriteLine("Account Holder: " + AccountHolderName);
            Console.WriteLine("Account Number: " + AccountNumber);
        }
        else
        {
            Console.WriteLine("Object is not a BankAccount");
        }
    }
}


class Program
{
    static void Main()
    {
        // creating object
        BankAccount acc1 = new BankAccount("Amit", 10151);
        BankAccount acc2 = new BankAccount("Riya", 10152);

        acc1.DisplayDetails(acc1);
        Console.WriteLine();

        acc2.DisplayDetails(acc2);
        Console.WriteLine();

        BankAccount.GetTotalAccounts();

        Console.ReadLine();
    }
}
