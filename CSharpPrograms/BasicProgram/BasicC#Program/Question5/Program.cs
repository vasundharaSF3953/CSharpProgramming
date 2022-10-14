using System;
namespace Question5;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your Physics Mark:");
        int physics=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your Chemistry Mark:");
        int chemistry=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your Maths Mark:");
        int maths=int.Parse(Console.ReadLine());

        int sum=physics+chemistry+maths;

        double percentage=(double) sum/300*100;

        Console.WriteLine($"Sum = {sum}");

        Console.WriteLine($"Percentage = {percentage}");


    }
}