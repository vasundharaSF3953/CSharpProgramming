using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        int a=1;
        int sum=0;
        Console.Write("Enter number of terms:");
        int num=int.Parse(Console.ReadLine());

        Console.Write($"The odd numbers are: ");
        for(int i=1; i<=num; i++ )
        {
            if(a%2!=0)
            {
              
              Console.Write(a+ " ");
              sum=sum+a; 
              a=a+2;
             
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine($"The Sum of odd natural Numbers upto {num} terms: {sum}");
        
    }
}
