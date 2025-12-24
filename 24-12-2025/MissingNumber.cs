using System;
class MissingNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter no of elements");
        int n=Convert.ToInt32(Console.ReadLine());
        int[] arr=new int[n];
        Console.WriteLine("Enter elements");
        for(int i=0;i<n;i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(arr);
        int found;
        for(int i=arr[0];i<=arr[n-1];i++)
        {
            found=0;
            for(int j=0;j<n;j++)
            {
                if(i==arr[j])
                {
                    found=1;
                    break;
                }
            }
            if(found==0)
            {
                Console.WriteLine("Missing Number = "+i);
            }
        }
    }
}



