using System;

class Friends
{
    static void FindYoungest(string[] names, int[] ages)//to find youngest
    {
        int minAge = ages[0];
        int index = 0;

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < minAge)
            {
                minAge = ages[i];
                index = i;
            }
        }

        Console.WriteLine("Youngest friend is " + names[index] + " with age " + minAge);
    }

    static void FindTallest(string[] names, int[] heights)//to find tallest
    {
        int maxHeight = heights[0];
        int index = 0;

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > maxHeight)
            {
                maxHeight = heights[i];
                index = i;
            }
        }

        Console.WriteLine("Tallest friend is " + names[index] + " with height " + maxHeight + " cm");
    }

    static void Main()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        int[] heights = new int[3];

        for (int i = 0; i < 3; i++)//input
        {
            Console.Write("Enter age of " + names[i] + ": ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter height of " + names[i] + " (in cm): ");
            heights[i] = Convert.ToInt32(Console.ReadLine());
        }

        FindYoungest(names, ages);
        FindTallest(names, heights);
    }
}
