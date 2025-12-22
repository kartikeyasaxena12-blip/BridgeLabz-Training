using System;
class LargestOf3
{
    static void Main(string[]args)
    {
        int n1= Convert.ToInt32(Console.ReadLine()); //Input
        int n2= Convert.ToInt32(Console.ReadLine());
        int n3= Convert.ToInt32(Console.ReadLine());

        if(n1>n2 && n1>n3)
        {
            Console.WriteLine("Is the first number the largest? YES");
        }
        else if(n2>n1 && n2>n3)
        {
            Console.WriteLine("Is the second number the largest? YES");
        }
        else{
            Console.WriteLine("Is the third number the largest? YES");
        }
    }
}