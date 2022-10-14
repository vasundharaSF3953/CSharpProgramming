using System;
namespace Question15;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any number:");
        int number=int.Parse(Console.ReadLine());

        int count=0;
        for(int i=2; i<3;i++)
        {
            if(number%2!=0)
            {
             count=1;
            }
        }
        if(count==1)
        {
            Console.WriteLine("It is prime number");
        }
        else
        {
          Console.WriteLine("It is not prime number");  
        }
        
    }
}
