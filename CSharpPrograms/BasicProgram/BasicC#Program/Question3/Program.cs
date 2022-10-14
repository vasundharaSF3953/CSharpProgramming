using System;
namespace Question4;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the amount of Celsius:");
        int celsius=int.Parse(Console.ReadLine());

        int fahrenheit=(celsius*9/5)+32;
         
        int kelvin= celsius+ (int)273.15;

        Console.WriteLine($"Kelvin = {kelvin}");

        Console.WriteLine($"Fahrenheit = {fahrenheit}");
        
        
    }
}