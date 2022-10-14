using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int a=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int b=int.Parse(Console.ReadLine());

        int holeSquare=a*a+2*a*b+b*b;
 
        Console.WriteLine($" The hole square is {holeSquare}");

    }
}