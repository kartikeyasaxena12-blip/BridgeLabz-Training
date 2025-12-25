using System;
class SumNatural
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Not a natural number. Program terminated.");
            return;
        }

        int recursiveSum = SumByRecursion(n);
        int formulaSum = SumByFormula(n);

        Console.WriteLine("Sum using recursion: " + recursiveSum);
        Console.WriteLine("Sum using formula: " + formulaSum);

        if (recursiveSum == formulaSum)
            Console.WriteLine("Both results are correct and equal.");
        else
            Console.WriteLine("Results are not equal.");
    }
        public static int SumByRecursion(int n)
    {
        if (n == 1)
            return 1;
        return n + SumByRecursion(n - 1);
    }

    public static int SumByFormula(int n)
    {
        return n * (n + 1) / 2;
    }
}
