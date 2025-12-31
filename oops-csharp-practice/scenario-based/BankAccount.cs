using System;
class BankAccount
{
    long balance = 10000; //balance available

    //if valid account number
    public void Display()
    {

        while(true)
        {
            Console.WriteLine();
            Console.WriteLine("............Main Menu...............");
            Console.WriteLine("1. To check balance");
            Console.WriteLine("2. To withdraw");
            Console.WriteLine("3. To deposit");
            Console.WriteLine("4. Exit");

            //enter choice 
            int ch= Convert.ToInt32(Console.ReadLine());

            switch(ch)
            {

                case 1:
                {
                    Console.WriteLine("Enter Password");
                    //enter password
                    int pass = Convert.ToInt32(Console.ReadLine());
                    if(pass == 1010)
                    {
                        CheckBalance();
                    }
                    else
                    {
                        Console.WriteLine("Wrong Password");
                    }
                    
                    break;
                }

                case 2:
                {
                    //enter amount to withdraw
                    Console.WriteLine("Enter Amount");
                    long amount = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter Password");
                    //enter password
                    int pass = Convert.ToInt32(Console.ReadLine());
                    if(pass == 1010)
                    {
                        Withdraw(amount);
                    }
                    else
                    {
                        Console.WriteLine("Wrong Password");
                    }
                    break;
                }

                case 3:
                {
                    //enter amount to deposit
                    Console.WriteLine("Enter Amount");
                    long amt = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter Password");
                    //enter password
                    int pass = Convert.ToInt32(Console.ReadLine());
                    if(pass == 1010)
                    {
                        Deposit(amt);
                    }
                    else
                    {
                        Console.WriteLine("Wrong Password");
                    }
                    break;
                }

                case 4:
                {
                    Console.WriteLine("Exit Successfully");
                    Environment.Exit(0);
                    break;
                }

                default:
                {
                    Console.WriteLine("Invalid Choice");
                    break;
                }
            }
        }
    }

    //method to check balance
    public void CheckBalance()
    {
        Console.WriteLine("Balance = "+balance);
    }

    // method  to deposit money
    public void Deposit(long amount)
    {
        if(amount>0)
        {
            balance+=amount;
            Console.WriteLine("Deposited Successfully");
        }
        else
        {
            Console.WriteLine("Invalid Amount");
        }
    }

    //method to withdraw amount
    public void Withdraw(long amount)
    {
        if(balance>=amount)
        {
            balance-=amount;
            Console.WriteLine("WithDrawn Successfully");
        }
        else
        {
            Console.WriteLine("Low Balance");
        }
    }
}

class App{
        static void Main(string[]args)
    {
        BankAccount obj = new BankAccount();

        Console.WriteLine("Enter Account Number");
        long accNumber = Convert.ToInt64(Console.ReadLine());// input account number

        if(accNumber == 554321)
        obj.Display();
        else
        Console.WriteLine("Invalid Account Number");// invalid account number
    }
}