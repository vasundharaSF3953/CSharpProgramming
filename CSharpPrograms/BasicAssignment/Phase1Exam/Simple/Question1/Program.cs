using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any number in inches:");
        float data=float.Parse(Console.ReadLine());

        double centimeter=data*2.54;

        Console.WriteLine("The centimeter of the number is "+centimeter);
        
    }
}
