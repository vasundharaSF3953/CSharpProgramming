using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
         Console.Write("Enter which matrix needed:");
         int matrix=int.Parse(Console.ReadLine());

         int[,] matrix1=new int[matrix,matrix];
         int[,] matrix2=new int[matrix,matrix];
         int[,] add=new int[matrix,matrix];

        Console.WriteLine("Enter the first matrix");
        for(int i=0;i<matrix;i++)
        {
            for(int j=0;j<matrix;j++)
            {
             Console.Write($"element- [{i}][{j}]=");
              matrix1[i,j]= int.Parse(Console.ReadLine());
                
            }
        }

        Console.WriteLine("Enter the second matrix");
        for(int i=0;i<matrix;i++)
        {
            for(int j=0;j<matrix;j++)
            {
             Console.Write($"element- [{i}][{j}]=");
              matrix2[i,j]= int.Parse(Console.ReadLine());
                
            }
        }

        
        Console.WriteLine("The addition of two matrix is:");
        for(int i=0;i<matrix;i++)
        {
            for(int j=0;j<matrix;j++)
            {
             add[i,j]=matrix1[i,j]+matrix2[i,j];
            }
        }

        for(int i=0;i<matrix;i++)
        {
            Console.WriteLine("");
            for(int j=0;j<matrix;j++)
            {
                Console.Write(add[i,j]+" ");
            }
        }

        
         
    }
}
