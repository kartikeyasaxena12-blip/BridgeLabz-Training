using System;
class Volume
{
    static void Main(string[] args)
    {
        double rad= Convert.ToDouble(Console.ReadLine());
        double height=Convert.ToDouble(Console.ReadLine());
        double vol= 3.14 * rad*rad*height;
        Console.WriteLine(vol);
    }
}