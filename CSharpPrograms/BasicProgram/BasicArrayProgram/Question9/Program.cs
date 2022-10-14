using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        int number;
        Console.Write("Enter the size of square matrix: ");
        number=int.Parse(Console.ReadLine());

        int[,] data1=new int[number,number];
        int[,] data2=new int[number,number];

        Console.WriteLine("Input elements in the first matrix:");
        for(int i=0; i<number;i++)
        {
            for(int j=0; j<number; j++)
            {
                Console.Write($"element-[{i}],[{j}]: ");
                data1[i,j]=int.Parse(Console.ReadLine());
                
            }
        }
        

        Console.WriteLine("Input elements in the second matrix:");
        for(int i=0; i<number;i++)
        {
            for(int j=0; j<number; j++)
            {
                Console.Write($"element-[{i}],[{j}]: ");
                data2[i,j]=int.Parse(Console.ReadLine());
                
            }
        }

        Console.WriteLine("First matrix is:");
        for(int i=0; i<number;i++)
        {
             Console.WriteLine("");
            for(int j=0; j<number; j++)
            {
                Console.Write(data1[i,j]+" ");
                
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Second matrix is:");
        for(int i=0; i<number;i++)
        {
             Console.WriteLine("");
            for(int j=0; j<number; j++)
            {
                Console.Write(data2[i,j]+" ");
                
            }
        }

          Console.WriteLine("");
        Console.WriteLine("The subtraction of two matrix is:");
        for(int i=0; i<number;i++)
        {
              Console.WriteLine("");
            for(int j=0; j<number; j++)
            {
                int a=data1[i,j]*data2[i,j];
                Console.Write(a+" ");
                
            }
        }
    }
}
