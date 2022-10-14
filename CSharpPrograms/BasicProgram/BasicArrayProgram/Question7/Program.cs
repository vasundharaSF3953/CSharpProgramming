using System;
namespace Question7;

class Program
{
    public static void Main(string[] args)
    {
        int number;
        Console.Write("Enter the 2D array size:");
        number=int.Parse(Console.ReadLine());

        int[,] value=new int[number,number];
        
        for(int i=0;i<number;i++)
        {
            for(int j=0; j<number; j++)
            {
                Console.Write($"element - [{i}],[{j}]: ");
                value[i,j]=int.Parse(Console.ReadLine());
                

            }
            
        }

        Console.WriteLine("The Matrix is");
        for(int i=0;i<number;i++)
        {
            Console.WriteLine();
            
            for(int j=0; j<number; j++)
            {
                Console.Write(value[i,j]);
                
                

            }
        }
    }
}
