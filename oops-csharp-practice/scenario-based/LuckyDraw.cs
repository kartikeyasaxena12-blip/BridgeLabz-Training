using System;
class LuckyDraw
{
    // main method
    static void Main(string[] args)
    {
        //creating object
        LuckyDraw obj = new LuckyDraw();
        obj.Display();
    }

    // display method
    void Display()
    {
        LuckyDraw obj = new LuckyDraw();

        Console.WriteLine("Enter number of Visitors");
        // input no of visitors
        int visitor = Convert.ToInt32(Console.ReadLine());
        int i=1;
        
        // it will execute till i is less than total no of visitors
        while(i<=visitor)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome To Diwali Mela ");
            Console.WriteLine("Press 1 to Draw the Number");
            // enter 1 to draw the number
            int ch= Convert.ToInt32(Console.ReadLine());

            if(ch==1)
            {
                // generating random number
                Random random = new Random();
                int number = random.Next(20);
                obj.WinGift(number,i);
                i++;
            }
            else
            {
                Console.WriteLine("Enter valid input");
            }
        }
    }

    //method to check whether a person win the gift or not
    void WinGift(int number, int visitor)
    {


        if(number % 3 == 0 && number % 5 == 0)
        {
            // if person won
            Console.WriteLine("Hurray! Visitor "+visitor+" Won and the number was "+number);
        }
        else
        {
            Console.WriteLine("Oops! Visitor "+visitor+" Got "+number+" Better Luck Next Time");
        }
    }
}