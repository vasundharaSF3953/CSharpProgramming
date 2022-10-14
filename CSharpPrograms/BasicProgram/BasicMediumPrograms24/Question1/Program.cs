using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of the hallway in meters:");
        float hallwayLength=float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width of the hallway in meters:");
        float width=float.Parse(Console.ReadLine());

        double workingDays=hallwayLength/0.12*width/0.7;
        
    

    }
}