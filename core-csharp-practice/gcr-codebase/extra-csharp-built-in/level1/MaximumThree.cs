using System;
class MaximumThree
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        int max = FindMaximum(a, b, c);

        Console.WriteLine("Maximum number is: " + max);
    }

    static int FindMaximum(int a, int b, int c)//to find max
    {
        int max = a;

        if (b > max)
            max = b;

        if (c > max)
            max = c;

        return max;
    }
}
