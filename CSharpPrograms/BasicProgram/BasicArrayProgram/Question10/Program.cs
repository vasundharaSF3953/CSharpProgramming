using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        int number1,number2;
        Console.Write("Enter row size of the  matrix: ");
        number1=int.Parse(Console.ReadLine());

        Console.Write("Enter the column size of the matrix: ");
        number2=int.Parse(Console.ReadLine());

        int[,] data1=new int[number1,number2];
       

        Console.WriteLine("Input elements in the first matrix is:");
        for(int i=0; i<number1;i++)
        {
            for(int j=0; j<number2; j++)
            {
                Console.Write($"element-[{i}],[{j}]: ");
                data1[i,j]=int.Parse(Console.ReadLine());
                
            }
        }

        Console.WriteLine("The transpose of a matrix is:");
        for(int i=0; i<number1;i++)
        {
            Console.WriteLine("");
            for(int j=0; j<number1; j++)
            {
                Console.Write(data1[j,i]);
                
                
            }
        }
        

    }
}