 using System;
 class TestScores
 {
    static void Main(string[]args)
    {
        Console.WriteLine("Enter number of students");
        int n=Convert.ToInt32(Console.ReadLine());//input total no of students
        Console.WriteLine("Enter scores");
        int[] arr= new int[n];// array to store scores
        for(int i=0;i<n;i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        TestScores obj= new TestScores();//creating object
        double avg=obj.Average(arr,n);
        Console.WriteLine("Average = "+avg);
        obj.HighestLowest(arr,n);
        obj.AboveAverage(arr,n,avg);

    }

    void AboveAverage(int[] arr,int n,double avg)//to find marks above average mark
    {
        for(int i=0;i<n;i++)
        {
            if(arr[i]>avg)
            {
                Console.WriteLine("Score above average = "+arr[i]);
            }
        }
    }

    double Average(int[] arr,int n)//to find average mark
    {
        double sum=0;
        for(int i=0;i<n;i++)
        {
            sum+=arr[i];
        }
        double avg=sum/n;
        return avg;
            }

    void HighestLowest(int[] arr,int n)//to find highest and lowest score
    {
        Array.Sort(arr);
        Console.WriteLine("Highest Score = "+arr[n-1]);
        Console.WriteLine("Lowest Score = "+arr[0]);
    }

 }