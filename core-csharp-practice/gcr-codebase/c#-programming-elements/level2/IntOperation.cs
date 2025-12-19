using System;
class IntOperation
{
    static void Main(string[]args)
    {
        int a= Convert.ToInt32(Console.ReadLine());
        int b= Convert.ToInt32(Console.ReadLine());
        int c= Convert.ToInt32(Console.ReadLine());
        int operation1= a+b*c;
        int operation2= a*b+c;
        int operation3= c+a/b;
        int operation4= a%b+c;

        Console.WriteLine("The results of Int Operations are "+operation1+", "+operation2+", "+operation3+", and "+operation4);

    }
}

