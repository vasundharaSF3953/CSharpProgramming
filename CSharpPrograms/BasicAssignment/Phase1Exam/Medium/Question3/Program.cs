using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any number:");
        int number1=int.Parse(Console.ReadLine());
        int temp=number1;

        int d,r=0;
        while(number1>0)
        {
            d=number1%10;
            number1=number1/10;
            r=r+d*10;

        }
        if(r==number1)
        {
            Console.WriteLine($"{temp} is palindrome");
        }
        else
        {
            Console.WriteLine($"{temp} is palindrome");
        }
        
    }
}