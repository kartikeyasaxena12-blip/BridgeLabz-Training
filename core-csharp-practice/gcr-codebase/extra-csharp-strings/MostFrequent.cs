using System;
class MostFrequent
{
    static void Main()
    {
        string input = Console.ReadLine();
        int maxCount = 0;
        char result = ' ';
        for (int i = 0; i < input.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < input.Length; j++)
            {
                if (input[i] == input[j])
                    count++;
            }
            if (count > maxCount)
            {
                maxCount = count;
                result = input[i];
            }
        }
        Console.WriteLine("Most Frequent Character: '" + result + "'");
    }
}
