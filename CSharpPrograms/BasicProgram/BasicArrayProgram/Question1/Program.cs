using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int value;
        
        Console.Write("Enter the number of elements in the array:");
        value=int.Parse(Console.ReadLine());
        int[] data=new int[value];

        for(int i=0; i<value;i++)
        {
            Console.Write($"Element - {i} : ");
            data[i]=int.Parse(Console.ReadLine());
            
        }

          Console.Write("Elements in array are:");
         for(int j=0; j<value;j++)
        {
           Console.Write(j+ " ");
        }
    }
}
