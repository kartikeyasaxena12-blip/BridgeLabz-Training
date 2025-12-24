using System;
class SumNumbers
{
    static void Main()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;
        for (int i = 0; i < 10; i++) //for loop
        {
            double input = Convert.ToDouble(Console.ReadLine());
            if (input <= 0)//to check for negative number
                break;
            numbers[index] = input;
            total += input;   // calculating sum
            index++;
        }
        Console.WriteLine("Numbers:");//Printing numbers
        for (int i = 0; i < index; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine("\nSum = " + total);
    }
}
