using System;
namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the text:");
        string a=Console.ReadLine();
        
        Console.WriteLine("Enter Your Name:");
        string name=Console.ReadLine();

        Console.WriteLine(a+" : "+name);

        Console.WriteLine($"{a} : {name}");

        Console.WriteLine("{0} : {1}",a,name);


    }
}