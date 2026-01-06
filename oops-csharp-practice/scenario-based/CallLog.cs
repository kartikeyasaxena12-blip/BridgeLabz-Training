using System;

class CallLogs
{
    public string phNo;
    public string mess;
    public DateTime time;

    public CallLogs(string phno, string message, DateTime dateTime)
    {
        phNo = phno;
        mess = message;
        time = dateTime;
    }

    public void Display()
    {
        Console.WriteLine("Phone number = "+phNo);
        Console.WriteLine("Message = "+ mess);
        Console.WriteLine("Time = "+time);
    }
}

class CallLogManager
{
    CallLogs[] log = new CallLogs[10];
    int count=0;

    public void AddCallLog(string phno, string mess, DateTime time)
    {
        log[count] = new CallLogs(phno,mess,time);
        count++;
    }

    public void SearchByKeyword(string message)
    {
        Console.WriteLine("Searched word = "+message);

        for(int i=0;i<count;i++)
        {
            if(log[i].mess.Contains(message))
            {
                log[i].Display();
            }
        }
    }
}

class Call
{
    static void Main(string[]args)
    {
        CallLogManager obj = new CallLogManager();

        obj.AddCallLog("5521512151", "hello",  DateTime.Now.AddHours(-5));
        obj.AddCallLog("5521515212", "how are you",  DateTime.Now.AddHours(-8));
        obj.AddCallLog("5525515151", "call me urgent",  DateTime.Now.AddHours(0));

        obj.SearchByKeyword("are");
        Console.WriteLine();
        obj.SearchByKeyword("me");

    }
}