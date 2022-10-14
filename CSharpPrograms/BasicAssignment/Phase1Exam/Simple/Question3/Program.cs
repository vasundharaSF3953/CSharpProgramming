using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the degree in radius:");
        int celsius=int.Parse(Console.ReadLine());

        float fahrenheit=(float)celsius*9/5+32;
        
        Console.WriteLine("The degree in Fahrenheit is:"+fahrenheit);
        
    }
}