using System;
class LargestSmallest
{
    static void Main(string[]args)
    {
        int number= Convert.ToInt32(Console.ReadLine());
        int[] digits = new int[10];   // array to store digits
        int index = 0;
        // Store digits of the number in array
        while (number!=0 && index<digits.Length)
        {
            digits[index] = number % 10; // get last digit
            number =number/10;                // remove last digit
            index++;
        }
        int largest = 0;
        int secondLargest = 0;

        for (int i = 0; i < index; i++)//for loop 
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }
        Console.WriteLine("Largest digit        : " + largest);//pritning largest and smallest
        Console.WriteLine("Second largest digit : " + secondLargest);
    }
}