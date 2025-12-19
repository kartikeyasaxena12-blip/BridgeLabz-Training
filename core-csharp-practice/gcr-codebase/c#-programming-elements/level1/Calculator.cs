using System;
class Calculator
{
    static void Main(string[]args)
    {
        int number1=Convert.ToInt32(Console.ReadLine());
        int number2=Convert.ToInt32(Console.ReadLine());
        int addition= number1+number2;
        int subtraction=number1-number2;
        int multiplication= number1*number2;
        int division= number1/number2;
        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+number1+" and "+number2+" is "+addition+", "+subtraction+", "+multiplication+", and "+division);
    }
}