using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.EduResults
{
    public class StudentUtility : IRank
    {
        private Student[] students;

        public StudentUtility(Student[] students)
        {
            this.students = students;
        }

        public void GenerateRankList()
        {
            MergeSort(0, students.Length - 1);

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Rank " + (i + 1) + " : " + students[i].GetScore());
            }
        }

        private void MergeSort(int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(left, mid);
                MergeSort(mid + 1, right);
                Merge(left, mid, right);
            }
        }

        private void Merge(int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            Student[] L = new Student[n1];
            Student[] R = new Student[n2];

            for (int i = 0; i < n1; i++)
                L[i] = students[left + i];

            for (int j = 0; j < n2; j++)
                R[j] = students[mid + 1 + j];

            int iIndex = 0, jIndex = 0, k = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (L[iIndex].GetScore() >= R[jIndex].GetScore())
                {
                    students[k++] = L[iIndex++];
                }
                else
                {
                    students[k++] = R[jIndex++];
                }

            }

            while (iIndex < n1)
                students[k++] = L[iIndex++];

            while (jIndex < n2)
                students[k++] = R[jIndex++];
        }
    }
}
