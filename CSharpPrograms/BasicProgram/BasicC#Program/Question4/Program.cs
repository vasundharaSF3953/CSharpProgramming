using System;
namespace Question4;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius of the cylinder:");
        int r=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Height of the Cylinder:");
        int h=int.Parse(Console.ReadLine());

        double volume=3.14*r*r*h;

        Console.WriteLine($"Volume:{volume}");

    }
}