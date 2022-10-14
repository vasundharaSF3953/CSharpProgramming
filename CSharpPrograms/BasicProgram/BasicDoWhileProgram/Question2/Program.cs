using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int num=0;
        int sum=0;
       do{
        sum=sum+num;
        Console.Write("Enter the number: ");
        num=int.Parse(Console.ReadLine());
        
        
       }while(num>=0); 
        Console.Write($"The Sum is: {sum}");

    }
}
