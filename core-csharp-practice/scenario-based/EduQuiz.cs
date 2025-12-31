using System;
class EduQuiz
{
    //main method
    public static void Main(string[] args)
    {
        //declaring a object 
        EduQuiz obj = new EduQuiz();

        Console.WriteLine("Quiz start");
        obj.Quiz(name);
    }

    //method which have quiz question and there answer
    string[,] Question()
    {
        string[,] questions = new string[10, 2] // declaring a 2d array which contaion question and answer
        {

            { "What is an array?", "An array stores multiple values of the same type." },
            { "What is the output of x++ when x=5?", "Output is 5." },
            { "What is a constructor?", "A constructor initializes an object." },
            { "Difference between == and Equals()?","== compares values or references, Equals() compares content." },
            { "What is encapsulation?","Encapsulation wraps data and methods together." },
            { "What is the output of loop 1 to 3?","Output is 1 2 3." },
            { "What is a primary key?","A primary key uniquely identifies records." },
            { "What is recursion?","A function calling itself." },
            { "What does break do?","It exits the loop immediately." },
            { "Default value of int in C#?","0" }
        };

        return questions;
    }

    //method for start the quiz which take input from students
    void Quiz(string name)
    {
        EduQuiz ob = new EduQuiz();//declaration of object
        string[,] question = ob.Question(); //call the question method and store the value in question 

        string[] studentAns = new string[question.GetLength(0)]; //this is use to store the answer of student

        int i = 0; 
        while (i < 10) //loop for taking input from student and store it in student answer string
        {
            Console.WriteLine("question no "+(i+1)+"." + question[i, 0]); // show question to the students
            Console.Write("Answer here: ");
            studentAns[i] = Console.ReadLine(); //taking input from student
            i++;
        }

        int score = Score(question, studentAns); 
        Console.WriteLine(score);//printing score
        float percentage = score*100f / studentAns.Length; 

        Console.WriteLine(name+" your percentage is " + percentage); //print the score

        if(percentage < 40) //check for pass or fail if less than 30% fail else fail
        {
            Console.WriteLine("Fail");
        }
        else
        {
            Console.WriteLine("Pass");
        }


    }

    //method use to calculate the score and give detail feedback
    int Score(string[,] question , string[] studentAns)
    {
        int score = 0; //intially the score is zero
        for(int i = 0; i < question.GetLength(0)-1; i++)
        {
            if (string.Equals(question[i,1], studentAns[i], StringComparison.OrdinalIgnoreCase)) //comapare the answer of the students with correct one case-insensetive
            {
                Console.WriteLine("Answer no " + (i + 1) + " is correct");
                score++; //increse score by 1 if answer is correct
            }
            else
            {
                Console.WriteLine("your answer is incorrect the correct answer is "+question[i, 1]);
            }

        }
        return score;
    }

    

}