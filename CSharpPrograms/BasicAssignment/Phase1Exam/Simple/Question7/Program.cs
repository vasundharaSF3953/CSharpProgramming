using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any number:");
        int number=int.Parse(Console.ReadLine());
        

        if(number>=0&&number<100)
        {
            Console.WriteLine("Less than 100");
        }
        else if(number>=100 ||number<200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else
        {
            Console.WriteLine("Greater than 200");
        }
    }
}