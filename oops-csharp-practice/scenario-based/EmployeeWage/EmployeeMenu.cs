using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeWage.EmployeeWage;

namespace EmployeeWage.EmployeeWage
{
    internal class EmployeeMenu
    {
       private EmployeeUtility utility;

        public void Run()
        {
            utility = new EmployeeUtility();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("press 1 To Add Employee");
                Console.WriteLine("press 2 To Check Daily Attendance");
                Console.WriteLine("press 3 To calculate daily wage");
                Console.WriteLine("press 4 to calculate monthly wage");
                Console.WriteLine("press 5 to Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        utility.AddEmployees();
                        break;

                    case 2:
                        utility.CheckAttendance();
                        break;
                    case 3:
                        utility.ShowDailyWages();
                        break;

                    case 4:
                        utility.CalculateMonthlyWage();
                        break;
                    case 5:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}