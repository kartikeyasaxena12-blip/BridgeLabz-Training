using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.EduResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student(85),
                new Student(92),
                new Student(85),
                new Student(70),
                new Student(95),
                new Student(92)
            };

            Menu menu = new Menu(students);
            menu.ShowMenu();
        }
    }
}
