using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Age");
        int age=int.Parse(Console.ReadLine());

        if(age>=18)
        {
            Console.WriteLine("Congrulations!");
            Console.WriteLine("You are eligible for casting your vote");
        }
        else
        {
            Console.WriteLine("You are not eligible for vasting your vote");
        }
        
    }
}