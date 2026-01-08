using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeWage.EmployeeWage;

namespace EmployeeWage.EmployeeWage
{
    internal class Employee
    {
        private string EmpId;
        private string EmpName;
        public void SetEmpName(string i)
        {
            EmpName = i;

        }
        public string GetEmpName()
        {
            return EmpName;
        }
       
        public void SetEmpId(string id)
        {
            EmpId = id;

        }
        public string GetEmpId()
        {
            return EmpId;
        }

        public double HourlyWage = 20;
        public int FullDay = 8;
        public double DailyWage = 0;
        public int PartTime = 4;


        public override string ToString()
        {
            return $"Employee: Name = {EmpName}, Id = {EmpId}";
        }



    }
}