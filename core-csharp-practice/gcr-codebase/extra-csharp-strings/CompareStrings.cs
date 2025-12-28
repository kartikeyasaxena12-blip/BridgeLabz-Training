using System;
class CompareStrings
{
    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        int len = s1.Length < s2.Length ? s1.Length : s2.Length;
        for (int i = 0; i < len; i++)
        {
            if (s1[i] < s2[i])
            {
                Console.WriteLine(s1 + " comes before " + s2);
                return;
            }
            else if (s1[i] > s2[i])
            {
                Console.WriteLine(s2 + " comes before " + s1);
                return;
            }
        }
        if (s1.Length == s2.Length)
            Console.WriteLine("Both strings are equal");
        else if (s1.Length < s2.Length)
            Console.WriteLine(s1 + " comes before " + s2);
        else
            Console.WriteLine(s2 + " comes before " + s1);
    }
}
