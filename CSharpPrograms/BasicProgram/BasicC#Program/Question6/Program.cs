using System;
namespace Question6;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the price amount for the product:");
        int price=int.Parse(Console.ReadLine());

        int total=price+price*18/100;
        Console.WriteLine($"Total = {total}");
        
        
    }
}