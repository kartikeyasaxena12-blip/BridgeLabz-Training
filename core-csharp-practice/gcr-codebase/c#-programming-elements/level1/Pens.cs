using System;
class Pens
{
    static void Main(string[]args)
    {
        int pen=14;
        int student=3;
        int remaining_pen= pen/student;
        int non_distributed_pen= pen%student;
        Console.WriteLine("The Pen Per Student is "+remaining_pen+" and the remaining pen not distributed is "+non_distributed_pen);
    }}