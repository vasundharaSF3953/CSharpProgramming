using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        int temp=1;
      
        Console.WriteLine("Enter the number:");
        int num=int.Parse(Console.ReadLine());
         for(int i=2; i<num; i++)
         {
            if(num%i==0)
            {
             temp=0;
             break;
            }

           
         }
         if(temp==1)
         {
             Console.WriteLine($"{num} is a prime number:");
         }
    }
}