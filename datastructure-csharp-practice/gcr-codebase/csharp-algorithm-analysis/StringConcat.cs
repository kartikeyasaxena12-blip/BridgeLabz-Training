using System;
using System.Text;

class StringConcat
{
    static void Main()
    {
        // Using string complexity = O(N^2)
        string str = "";
        for (int i = 0; i < 100000; i++)
        {
            str += "ABC";
        }

        // Using StringBuilder complexity = O(N)
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 100000; i++)
        {
            sb.Append("ABC");
        }

        Console.WriteLine("Concatenation completed using string and StringBuilder");
    }
}
