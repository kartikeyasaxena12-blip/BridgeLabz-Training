using System;
class DoubleOpt
{
    static void Main(string[]args)
    {
        Double a= Convert.ToDouble(Console.ReadLine());
        Double b= Convert.ToDouble(Console.ReadLine());
        Double c= Convert.ToDouble(Console.ReadLine());
        Double operation1= a+b*c;
        Double operation2= a*b+c;
        Double operation3= c+a/b;
        Double operation4= a%b+c;

        Console.WriteLine("The results of Double Operations are "+operation1+", "+operation2+", "+operation3+", and "+operation4);

    }
}

