using System;

class BaseClass
{
    public int pubVar= 2;
    private int priVar=3;
    protected int protVar=4;
    internal int inteVar=5;
    protected internal int protInt=6;
    private protected int privInt=7;

    public void fun1() //method in same class
    {
        Console.WriteLine("Inside Baseclass");
        Console.WriteLine(pubVar+" public");
        Console.WriteLine(priVar+" private");
        Console.WriteLine(protVar+" protected");
        Console.WriteLine(inteVar+" internal");
        Console.WriteLine(protInt+" protected Internal");
        Console.WriteLine(privInt+" private protected");
    }
}

class DerivedClass:BaseClass //derived class
{
    public void fun2()
    {
        Console.WriteLine("Inside Derivedclass");// except private
        Console.WriteLine(pubVar+" public");
        Console.WriteLine(protVar+" protected");
        Console.WriteLine(inteVar+" internal");
        Console.WriteLine(protInt+" protected Internal");
        Console.WriteLine(privInt+" private protected");      
    }
}

class NonDerived //non derived class
{
    public void fun3()
    {
        BaseClass obj= new BaseClass();
        Console.WriteLine("Inside NonDerived Class");// except private,protected,private Internal
        Console.WriteLine(obj.pubVar+" public");
        Console.WriteLine(obj.inteVar+" Internal");
        Console.WriteLine(obj.protInt+" protected Internal");
    }
}

class Program
{
    static void Main(string[]args)
    {
        BaseClass baseObj= new BaseClass();
        baseObj.fun1();
        DerivedClass deriObj= new DerivedClass();
        deriObj.fun2();
        NonDerived nonObj= new NonDerived();
        nonObj.fun3();

    }
}