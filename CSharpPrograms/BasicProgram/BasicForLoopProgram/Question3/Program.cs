using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of terms: ");
        int num=int.Parse(Console.ReadLine());

        for(int i=1; i<=num;i++)
        {
         int cube=i*i*i;
          Console.WriteLine($"Number is: {i} and cube of {1} is: {cube} ");   
        }
        
    }
}
