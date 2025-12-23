using System;
class Calculator{
    public static void Main(string[] args){
		//taking input
        Console.WriteLine("Enter numbers : ");
        double first = Convert.ToDouble(Console.ReadLine());
        double second = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter operand");
        string op= Console.ReadLine();

        switch(op)// switch statement
        {
            case "+":
            {
                Console.WriteLine("Result = "+(first+second));
                break;
            }
            case "-":
            {
                Console.WriteLine("Result = "+(first-second));
                break;
            }
            case "*":
            {
                Console.WriteLine("Result = "+(first*second));
                break;
            }
            case "/":
            {
                Console.WriteLine("Result = "+(first/second));
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Input");
                break;
            }
        }
    }
}
