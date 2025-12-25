using System;
public class Vote
{
    public static bool CanStudentVote(int age)//to check vote
    {
        if (age < 0)
        {
            return false; 
        }

        if (age >= 18)
        {
            return true; 
        }
        else
        {
            return false; // cannot vote
        }
    }

    public static void Main()
    {
        int[] ages = new int[10];

        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Enter age of student " + (i + 1) + ": ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            bool canVote = CanStudentVote(ages[i]);

            if (canVote)
            {
                Console.WriteLine("Student " + (i + 1) + " can vote.");
            }
            else
            {
                Console.WriteLine("Student " + (i + 1) + " cannot vote.");
            }
        }
    }
}
