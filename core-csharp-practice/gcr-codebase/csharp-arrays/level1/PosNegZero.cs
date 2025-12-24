using System;
class PosNegZero
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter of 5 numbers");
        int[] nums= new int[5];
        for(int i=0;i<5;i++)
        {
            nums[i]=Convert.ToInt32(Console.ReadLine());
        } 
        for(int i=0;i<5;i++)
        {
            if(nums[i]>0)
            {
                if(nums[i]%2==0)
                {
                    Console.WriteLine(nums[i]+" Even");
                }
                else
                {
                    Console.WriteLine(nums[i]+" Odd");
                }
            }
            else if(nums[i]<0)
            {
                Console.WriteLine(nums[i]+" Negative");
            }
            else
            {
                Console.WriteLine(nums[i]+" Zero");
            }
        }
        if(nums[0]==nums[4])
        {
            Console.WriteLine("First and Last elements are equal");
        }
        else if(nums[0]>nums[4])
        {
            Console.WriteLine("First element is greater");
        }
        else{
            Console.WriteLine("Last element is greater");
        }
    }
}