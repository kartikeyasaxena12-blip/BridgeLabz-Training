using System;
class StringCount
{
    static void Main()
    {
        string str = Console.ReadLine();
        string sub = Console.ReadLine();
        int count = 0;
        for (int i = 0; i <= str.Length - sub.Length; i++)
        {
            int j;
            for (j = 0; j < sub.Length; j++)
            {
                if (str[i + j] != sub[j]) 
                break;
            }
            if (j == sub.Length) count++;
        }
        Console.WriteLine(count);
    }
}
