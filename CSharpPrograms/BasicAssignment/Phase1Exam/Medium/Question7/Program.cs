using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the starting number:");
        int number=int.Parse(Console.ReadLine());

        Console.Write("Enter the number of elements:");
        int element=int.Parse(Console.ReadLine());

        
        Console.Write("Enter the number difference:");
        int difference=int.Parse(Console.ReadLine());

        int sum=0;
        for(int i=0;i<element;i++)
        {
            Console.Write(number+" ");
            number=number+difference;
            sum=sum+number;
        }
        Console.WriteLine(" ");
        Console.WriteLine("Sum is Output:"+sum);
    }
}
