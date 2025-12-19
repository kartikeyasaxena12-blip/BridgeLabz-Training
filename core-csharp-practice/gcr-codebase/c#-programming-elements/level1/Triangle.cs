using System;
class Triangle
{
    static void Main(string[]args)
    {
        double bas= Convert.ToDouble(Console.ReadLine());
        double height= Convert.ToDouble(Console.ReadLine());
        double areacenti= 0.5*bas*height;
        double heightinch= height/2.54;
        double baseinch= bas/2.54;
        double areainch= 0.5*baseinch*heightinch;
        Console.WriteLine("Area of Triangle in square inches "+areainch+" and square centimeters "+areacenti);
    }
}

