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
        int mathematics=int.Parse(Console.ReadLine());

        int sum=physics+chemistry+mathematics;

        float Percentage=(float)sum/300*100;

       if(Percentage>=75)
       {
        Console.WriteLine("The candidate is eligible for admission");
       }
       else
       {
         Console.WriteLine("The candidate is not eligible for admission");
       }
    }
}