using System;
class Chocolates
{
    public static void Find(int choco, int children)
    {
        int quotient = choco / children;
        int remainder = choco % children;
        Console.WriteLine("Each child will get " + quotient + " chocolates");
        Console.WriteLine("Remaining chocolates: " + remainder);
    }

    static void Main()
    {
        Console.Write("Enter the number of chocolates: ");
        int choco = Convert.ToInt32(Console.ReadLine());//input
        Console.Write("Enter no of children: ");
        int children = Convert.ToInt32(Console.ReadLine());
        Find(choco, children);//method
    }
}