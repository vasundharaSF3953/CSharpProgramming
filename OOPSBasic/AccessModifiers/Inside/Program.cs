using System;


namespace Inside;
class Program
{
    public static void Main(string[] args)
    {
        First one=new First();  //object creation
        Console.WriteLine(one.PublicNumber);
        Console.WriteLine(one.PrivateOutput);
        Console.WriteLine(one.InternalNumber);
        
        Second two=new Second();  //object creation
        Console.WriteLine(two.ProtectedOutput);
        Console.WriteLine(two.ProtectedInternalOutput);

    }
}