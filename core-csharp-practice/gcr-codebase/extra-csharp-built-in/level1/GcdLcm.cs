using System;
class GcdLcm
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        int a = Convert.ToInt32(Console.ReadLine());//input
        int b = Convert.ToInt32(Console.ReadLine());
        int gcd = FindGCD(a, b);
        int lcm = FindLCM(a, b);
        Console.WriteLine("GCD = " + gcd);//print
        Console.WriteLine("LCM = " + lcm);
    }

    static int FindGCD(int x, int y)
    {
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }
        return x;
    }

    static int FindLCM(int x, int y)
    {
        return (x * y) / FindGCD(x, y);
    }
}
