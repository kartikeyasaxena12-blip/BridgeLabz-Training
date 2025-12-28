using System;

class NumberGuessingGame
{
    static void Main()
    {
        Console.WriteLine("Think of a number between 1 and 100.");
        Console.WriteLine("Enter 'h' for high, 'l' for low, 'c' for correct.\n");
        int low = 1;
        int high = 100;
        bool isCorrect = false;

        while (!isCorrect)
        {
            int guess = GenerateGuess(low, high);
            Console.WriteLine("Computer guess: " + guess);

            Console.Write("Your feedback (h/l/c): ");
            char feedback = Console.ReadLine()[0];

            if (feedback == 'c')
            {
                Console.WriteLine("Computer guessed the number!");
                isCorrect = true;
            }
            else if (feedback == 'h')
            {
                high = guess - 1;
            }
            else if (feedback == 'l')
            {
                low = guess + 1;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }
    }

    static int GenerateGuess(int low, int high)// Function only for generating guesses
    {
        Random rand = new Random();
        return rand.Next(low, high + 1);
    }
}
