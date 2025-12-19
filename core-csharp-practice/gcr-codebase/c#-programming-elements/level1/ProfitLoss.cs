using System;
class ProfitLoss
{
    static void Main(string[]args)
    {
        double selling_price= 191;
        double cost_price= 129;
        double profit = selling_price - cost_price;
        double percentage = profit / cost_price * 100;
        Console.WriteLine("The Cost Price is INR "+cost_price+" and Selling Price is INR "+selling_price);
        Console.WriteLine("The Profit is INR "+profit+" and the Profit Percentage is "+percentage);
    }}