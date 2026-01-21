using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.EduResults
{
    public class Menu
    {
        private Student[] students;

        public Menu(Student[] students)
        {
            this.students = students;
        }

        public void ShowMenu()
        {
            IRank rank = new StudentUtility(students);
            rank.GenerateRankList();
        }
    }
}
