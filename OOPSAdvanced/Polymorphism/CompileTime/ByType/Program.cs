using System;
namespace ByType;

class Program
{

 
    static void Display(int number)     //Method with integer as parameter
    {
        Console.WriteLine("Number is:"+number);
    }

    static void Display(string name)   //Method with string as parameter
    {
        Console.WriteLine("Your Name is:"+name);
    }
    public static void Main(string[] args)
    {
        Display(10);
        Display("Vasundhara");
        
    }
}

