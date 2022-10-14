using System;
namespace Question8;

class Program
{
   public static void Main(string[] args)
   {
    Console.WriteLine("Enter the Meter:");
    int meter=int.Parse(Console.ReadLine());

    int cm=meter*100;
    int mm=cm*10;
    double inch=39.3*meter;
    int foot=12*meter;
    double mile=0.00006213715277778*meter;

    Console.WriteLine($"The CM is : {cm}");
    Console.WriteLine($"The MM is : {mm}");
    Console.WriteLine($"The INCH is : {inch}");
    Console.WriteLine($"The FOOT is : {foot}");
    Console.WriteLine($"The MILE is : {mile}");

   }
}