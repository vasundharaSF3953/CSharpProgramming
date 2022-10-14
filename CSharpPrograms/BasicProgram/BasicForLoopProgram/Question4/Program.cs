using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the input number:");
        int num=int.Parse(Console.ReadLine());
        
        for(int i=1; i<=10;i++)
        {
          int n=num*i;  
          Console.WriteLine($"{num} X {i} = {n} ");  
        }
    }
}

