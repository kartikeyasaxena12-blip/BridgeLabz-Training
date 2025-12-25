using System;
class SI
{
    static void Main(string[] args)
    {
        Console.Write("Enter Principal: ");//taking input
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time: ");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = CalculateSimpleInterest(principal, rate, time);//calling method
        Console.WriteLine("The Simple Interest is " + simpleInterest +" for Principal " + principal +", Rate of Interest " + rate +" and Time " + time);

    static double CalculateSimpleInterest(double principal, double rate, double time)//calculating si
    {
        return (principal * rate * time) / 100;
    }
    }
}
