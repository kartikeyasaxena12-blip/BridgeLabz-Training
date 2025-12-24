using System;
class Vote
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter age of 10 students");
        int[] age= new int[10];
        for(int i=0;i<10;i++)
        {
            age[i]=Convert.ToInt32(Console.ReadLine());
        } 
        for(int i=0;i<10;i++)
        {
            if(age[i]<0)
            {
                Console.WriteLine("Invalid Age");
            }
            else if(age[i]>=18)
            {
                Console.WriteLine("The student with the age "+age[i]+" can vote");
            }
            else{
                Console.WriteLine("The student with the age "+age[i]+" cannot vote");
            }
        }

    }
}