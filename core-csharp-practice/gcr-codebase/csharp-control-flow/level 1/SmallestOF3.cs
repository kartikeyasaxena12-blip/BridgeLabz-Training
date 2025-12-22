using System;
class SmallestOF3
{
    static void Main(string[]args)
    {
        int n1= Convert.ToInt32(Console.ReadLine());
        int n2= Convert.ToInt32(Console.ReadLine());
        int n3= Convert.ToInt32(Console.ReadLine());

        if(n1<n2 && n1<n3)
        {
            Console.WriteLine("Is the first number the smallest? YES");
        }
        else
        {
            Console.WriteLine("Is the first number the smallest? NO");
        }
    }
}