using System;
class SmallestLargest
{
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)//to find smallest and largest
    {
        int smallest = number1;
        int largest = number1;
        if (number2 < smallest)
            smallest = number2;
        if (number2 > largest)
            largest = number2;
        if (number3 < smallest)
            smallest = number3;
        if (number3 > largest)
            largest = number3;
        return new int[] { smallest, largest };
    }
    static void Main()
    {
        Console.Write("Enter first number: ");//input number
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        int[] result = FindSmallestAndLargest(number1, number2, number3);//calling function
        Console.WriteLine("Smallest number: " + result[0]);//printing
        Console.WriteLine("Largest number: " + result[1]);
    }
}