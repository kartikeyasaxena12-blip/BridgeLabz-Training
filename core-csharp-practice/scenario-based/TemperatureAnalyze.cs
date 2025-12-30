using System;
class TemperatureAnalyze
{
    static void Main(string[] args)//main function
    {
        //2d array
        float[,] temp =
        {
            // Day 1
            { 9,8,8,7,7,6,7,9,12,15,18,20,22,23,24,23,21,19,17,15,13,12,11,10 },
            // Day 2
            { 8,7,7,6,6,5,6,8,11,14,17,19,21,22,23,22,20,18,16,14,12,11,10,9 },
            // Day 3
            { 10,9,9,8,8,7,8,10,13,16,19,21,23,24,25,24,22,20,18,16,14,13,12,11 },
            // Day 4
            { 11,10,10,9,9,8,9,11,14,17,20,22,24,25,26,25,23,21,19,17,15,14,13,12 },
            // Day 5
            { 9,8,8,7,7,6,7,9,12,15,18,20,22,23,24,23,21,19,17,15,13,12,11,10 },
            // Day 6
            { 8,7,7,6,6,5,6,8,11,14,17,19,21,22,23,22,20,18,16,14,12,11,10,9 },
            // Day 7
            { 7,6,6,5,5,4,5,7,10,13,16,18,20,21,22,21,19,17,15,13,11,10,9,8 }
        };

        //creating objects
        TemperatureAnalyze obj= new TemperatureAnalyze();
        obj.Display(temp);


    }

    void Display(float[,] temp)//to dispay and call functions
    {
        TemperatureAnalyze obj= new TemperatureAnalyze();

        float[] avg = obj.AverageTemp(temp);
        for(int i=0;i<avg.Length;i++)
        {
            Console.WriteLine("Average Temperature of Day "+(i+1)+" = "+avg[i]);// displaying average temperature
        }

        obj.Hottest_Day(avg);
        obj.Coldest_Day(avg);



    }

    //method to find average temperature
    float[] AverageTemp(float[,]temp)
    {
        float[] avg= new float[7];
        for(int i=0;i<7;i++)
        {
            float a=0;
            for(int j=0;j<24;j++)
            {
                a+=temp[i,j];
            }
            avg[i]=a/24;//calculating average
        }
        return avg;
    }

    //method to find hottest day
    void Hottest_Day(float[] avg)
    {
        int day=0;
        float temp=0;
        for(int i=0;i<avg.Length;i++)
        {
            if(avg[i]>temp)
            {
                day=i+1;
                temp=avg[i];
            }
        }
        Console.WriteLine("Hottest Day is Day "+day+" with average temperature = "+temp);//printing hottest day
    }

    //method to find coldest day
    void Coldest_Day(float[] avg)
    {
        int day=1;
        float temp=avg[0];
        for(int i=1;i<avg.Length;i++)
        {
            if(avg[i]<temp)
            {
                day=i+1;
                temp=avg[i];
            }
        }
        Console.WriteLine("Coldest Day is Day "+day+" with average temperature = "+temp);//printing coldest day
    }
} 