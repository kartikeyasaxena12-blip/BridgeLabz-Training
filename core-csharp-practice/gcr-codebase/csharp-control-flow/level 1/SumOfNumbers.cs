// Write a program to find the sum of numbers until the user enters 0
// Hint => 
// Create a variable total of type double initialize to 0.0. Also, create a variable to store the double value the user enters
// Use the while loop to check if the user entered is 0
// If the user entered value is not 0 then inside the while block add user entered value to the total and ask the user to input again
// The loop will continue till the user enters zero and outside the loop display the total value


using System;
class SumOfNumbers
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter a nmber");
        double number = Convert.ToDouble(Console.ReadLine()); //input
        
        double total=0.0; //to store sum
        while(number!=0)
        {
            total = total+number;
            Console.WriteLine("Enter a number or zero to stop");
            number = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Sum of Numbers = "+total);
    }
}