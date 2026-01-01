using System;
class FreeLancer
{
    // main method
    static void Main(string[] args)
    {
        // creating object
        FreeLancer obj = new FreeLancer();

        Console.WriteLine("Enter Invoice Details");
        // input invoice details
        string str= Console.ReadLine();

        string[] details= str.Split(','); // split details by comma
        
        obj.ShowDetails(details);

    }

    // method to show details and invoice amount
    void ShowDetails(string[] details)
    {
        FreeLancer obj = new FreeLancer();

        Console.WriteLine();
        Console.WriteLine(".............Invoice...........");

        for(int i=0;i<details.Length;i++)
        {
            // displaying invoice details
            Console.WriteLine(details[i].Trim());
        }

        // to get total invoice amount
        double total = obj.GetTotalAmount(details);

        Console.WriteLine("Total Amount = "+total);
    }

    // method to get total invoice amount
    double GetTotalAmount(string[] details)
    {

        double total=0;

        for(int i=0;i<details.Length;i++)
        {
            // splitting details by - to get amount
            string[] parts = details[i].Split('-');
            // replacing INR with ""
            string amountPart = parts[1].Replace("INR", "").Trim();
            // converting string to double
            double amount = Convert.ToDouble(amountPart);
            total+=amount;
        }
        return total;
    }
}