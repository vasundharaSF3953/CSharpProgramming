using System;
namespace Question4;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int num1=int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the second number:");
        int num2=int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the third number:");
        int num3=int.Parse(Console.ReadLine());

        if(num1>num2)
        {
            if(num1>num3)
            {
               Console.WriteLine("The 1st number is the greatest among three");  
            }
            else
            {
                Console.WriteLine("The 3st number is the greatest among three"); 
            }
        }
        else 
        {
            if(num2>num3)
            {
               Console.WriteLine("The 2nd number is the greatest among three");  
            }
            else
            {
                Console.WriteLine("The 3st number is the greatest among three"); 
            } 
        }
        
    }
}