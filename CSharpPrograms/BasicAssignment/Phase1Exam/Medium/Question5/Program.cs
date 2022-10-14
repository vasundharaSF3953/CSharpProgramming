using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the starting range:");
        int start=int.Parse(Console.ReadLine());
        
        Console.Write("Enter the ending range:");
        int end=int.Parse(Console.ReadLine());

        for(int i=start;i<=end;i++)
        {
            if(i%4==0)
            {
                Console.Write(i+" ");
            }
        }

    }
}
