using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the password:");
        string password=Console.ReadLine();
        
        if(password=="s3cr3t!p@sswOrd")
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong Password!");
        }
    }
}
