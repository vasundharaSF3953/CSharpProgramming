using System;
namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Number:");
        int number=int.Parse(Console.ReadLine());

        if(number%2==0)
        {
            Console.WriteLine($"{number} is an even number");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number");
        }
    }
}