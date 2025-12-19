using System;
class IsOperator
{
    static void Main()
    {
        object x=20;
        if(x is int)
        {
            Console.WriteLine("Integer");
        }
        if(x is string)
        {
            Console.WriteLine("String");
        }
    }
}