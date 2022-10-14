using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int number1=0,number2=1,number3;
        Console.Write("Enter the number of terms to display:");
        int  terms=int.Parse(Console.ReadLine());

        Console.WriteLine($"Here is the fibonacci series upto {terms} is");
        Console.Write(number1+ " "+number2+" ");
        for(int i=2;i<terms;i++)
        {
           number3=number1+number2;
           Console.Write(number3+" ");
           number1=number2;
           number2=number3;
        }
        
    }
}
