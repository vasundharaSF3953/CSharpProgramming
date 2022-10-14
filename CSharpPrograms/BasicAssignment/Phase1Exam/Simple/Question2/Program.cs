using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the radius of the circle:");
        double radius=double.Parse(Console.ReadLine());

        double area=3.14*radius*radius;
        double perimeter=2*3.14*radius;

        Console.WriteLine($"Area= {area}");
        Console.WriteLine($"Perimeter= {perimeter}");
    }
}
