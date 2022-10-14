using System;
namespace Question9;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the speed of the vehicle:");
        int speed=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the time travelled by the  vehicle:");
        int time=int.Parse(Console.ReadLine());

        int distance=speed*time*5/18;

        Console.WriteLine($"The distance travelled by the vehicle is : {distance} meters");
        
    }
}