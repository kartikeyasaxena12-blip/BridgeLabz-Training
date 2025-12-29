using System;
class AutoCorrect
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter Sentence");//input sentence
        string s= Console.ReadLine();
        Display(s);//to print sentence

    }

    static void Display(string s)
    {
        string s1=OneSpace(s);//storing after adding one space after punctuation
        string s2=TrimSpace(s1);//storing after removing extra spaces
        string s3=CapitalLetter(s2);// storing after capitalizing letter after punctuation
        Console.WriteLine(s3);//printing the final sentence
    }

    static string OneSpace(string str)//method to add space
    {
        string res="";
        for(int i=0;i<str.Length-1;i++)
        {
            char c= str[i];
            if(char.IsPunctuation(c))
            {
                res+=c;
                res+=" ";
            }
            else
            {
                res+=c;
            }
        }
        res+=str[str.Length-1];
        return res;
    }

    static string TrimSpace(string str)//method to trim space
    {
        string res="";

        for(int i=0;i<str.Length;i++)
        {
            if(!(str[i]==' '&& str[i+1]==' '))
            {
                res+=str[i];
            }
        }
        return res;
    }

    static string CapitalLetter(string str)//method to capitalize letter
    {
        string res="";
        res+=char.ToUpper(str[0]);//first letter capital
        res+=str[1];//adding second letter because loop starting from index 2

        for(int i=2;i<str.Length;i++)
        {
            if((str[i-2]=='.'||str[i-2]=='!'||str[i-2]=='?'))
            {
                res+=char.ToUpper(str[i]);
            }
            else{
                res+=str[i];
            }
        }
        return res;

    }


}