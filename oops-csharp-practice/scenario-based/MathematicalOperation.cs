using System;
class MathematicalOperation
{
    static void Main(string[]args)// main method
    {

        // creating object
        MathematicalOperation obj= new MathematicalOperation();
        obj.Display();

    }

    void Display()
    {
        MathematicalOperation obj= new MathematicalOperation();
        // menu
        Console.WriteLine("1. Factorial");
        Console.WriteLine("2. Prime");
        Console.WriteLine("3. GCD");
        Console.WriteLine("4. Fibonacci");

        //enter option to select
        int ch= Convert.ToInt32(Console.ReadLine());

        switch(ch)
        {
            case 1:
            {
                    Console.WriteLine("Enter a Number");
                    //taking user input
                    int n= Convert.ToInt32(Console.ReadLine());
                    if(n>=0)
                    {
                        long factorial= obj.Factorial_Num(n);
                        Console.WriteLine("Factorial = "+factorial); // printing factorial
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number");
                    }
                    break;
            }
            case 2:
            {
                    Console.WriteLine("Enter a Number");
                    //taking user input
                    int n= Convert.ToInt32(Console.ReadLine());
                    if(n>0)
                    {
                        obj.PrimeNumber_Check(n); // checking for prime
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number");
                    }
                    break;
            }  

            case 3:
            {
                    Console.WriteLine("Enter two Numbers");
                    //taking user input
                    int a= Convert.ToInt32(Console.ReadLine());
                    int b= Convert.ToInt32(Console.ReadLine());
                    if(a>0 && b>0)
                    {
                        obj.FindGCD(a,b); // finding gcd
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number");
                    }
                    break;
            }       

            case 4:
            {
                    Console.WriteLine("Enter a Number");
                    //taking user input
                    int n= Convert.ToInt32(Console.ReadLine());
                    if(n>0)
                    {
                        obj.PrintFibonacci(n);// printing fibonacci series
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number");
                    }
                    break;
            }
            default:
            {
                Console.WriteLine("Invalid Choice");
                break;
            }                    
        }
    }

    long Factorial_Num(int n)// method to find factorial
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }    
        return n * Factorial_Num(n - 1);
    }

    //method to check prime number
    void PrimeNumber_Check(int a) 
    {
        bool isPrime=true;
        for(int i=2;i<a;i++)
        {
            if(a%i==0)
            {
                isPrime=false;
                break;
            }
        }
        if(isPrime)
        Console.WriteLine("Prime Number");
        else
        Console.WriteLine("Not a Prime Number");
    }

    // method to find GCD of two numbers
    void FindGCD(int x, int y)
    {
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }
        Console.WriteLine(x);
    }

    // Function to calculate and print Fibonacci number
    void PrintFibonacci(int n)
    {
        int a = 0, b = 1;
        for (int i = 1; i <= n; i++)
        {
            int next = a + b;
            a = b;
            b = next;
        }
        Console.Write(a);
    }
}

