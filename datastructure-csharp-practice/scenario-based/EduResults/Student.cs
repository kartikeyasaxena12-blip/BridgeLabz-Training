using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.EduResults
{
    public class Student
    {
        private int score;

        public Student(int score)
        {
            this.score = score;
        }

        public int GetScore()
        {
            return score;
        }
    }
}
