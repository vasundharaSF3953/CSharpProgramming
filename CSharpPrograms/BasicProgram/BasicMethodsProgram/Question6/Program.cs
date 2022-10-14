using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        int number,fact=1;
        Console.Write("Enter the number: ");
        number=int.Parse(Console.ReadLine());
        
        Factorial(number);
       

        void Factorial(int data1)
        {
            for(int i=1;i<=data1;i++)
            {
                
                fact=fact*i;
            } 

               System.Console.WriteLine($"The factorial of {data1}! is:"+fact);  

            
        }
        
    }
}
