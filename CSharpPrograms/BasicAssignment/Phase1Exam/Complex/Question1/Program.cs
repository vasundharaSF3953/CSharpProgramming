using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of rows needed  for first matrix:");
        int row1=int.Parse(Console.ReadLine());
        
        Console.Write("Enter the number of column needed for first matrix:");
        int column1=int.Parse(Console.ReadLine());

        Console.Write("Enter the number of rows needed for second  matrix:");
        int row2=int.Parse(Console.ReadLine());

        Console.Write("Enter the number of column needed for second matrix:");
        int column2=int.Parse(Console.ReadLine());

        int[,] matrix1=new int[row1,column1];
        int[,] matrix2=new int[row2,column2];
        int[,] matrix3=new int[row1,row1];

        Console.WriteLine("Enter the first matrix:");
        for(int i=0;i<row1;i++)
        {
            for(int j=0;j<column1;j++)
            {
                Console.Write($"element-[{i}] [{j}]= ");
                matrix1[i,j]=int.Parse(Console.ReadLine());
                
            }
        }

        Console.WriteLine("Enter the second matrix:");
        for(int i=0;i<row2;i++)
        {
            for(int j=0;j<column2;j++)
            {
                Console.Write($"element-[{i}] [{j}]= ");
                matrix2[i,j]=int.Parse(Console.ReadLine());
                
            }
        }


          Console.WriteLine("The multiplication of two matrix is:");

          for(int i=0;i<row1;i++)
          {
            for(int j=0;j<=row1;j++)
            {
                for(int k=0;k<=i;k++)
                {
                    matrix3[i,j]=matrix1[i,j]*matrix2[j,k];
                }
                
            }
          }


         
    }
}
