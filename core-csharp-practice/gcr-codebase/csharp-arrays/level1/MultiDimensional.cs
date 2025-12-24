using System;
class MultiDimensional
{
    public static void Main(string[] args)
    {   
        Console.WriteLine("Enter number of rows");//input rows and columns
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of columns");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] arr2D = new int[rows, cols];//2d array
        Console.WriteLine("Enter elements of the 2D array");//input
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr2D[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int size=rows * cols;

        int[] arr1D = new int[size];//1d array
        for (int i = 0, k = 0; i < rows; i++)//2d to 1d
        {
            for (int j = 0; j < cols; j++)
            {
                arr1D[k] = arr2D[i, j];
                k++;
            }
        }
        Console.WriteLine("1D array");
        for (int i = 0; i < size; i++)
        {
            Console.Write(arr1D[i]+" "); // print 1D array
        }
    }
}