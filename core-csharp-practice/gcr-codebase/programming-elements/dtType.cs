using System;
class DtType
{
    static void Main()
    {
        double a=9.1;
        object b= Convert.ToInt32(a); // converting double to int
        if(b is int)
        {
            Console.WriteLine("INT");
        }
        object c= Convert.ToInt64(b); // converting int to long
        if(c is long)
        {
            Console.WriteLine("Long");
        }
    }
}