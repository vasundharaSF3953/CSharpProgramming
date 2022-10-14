using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
       
        int number;
        Console.Write("Enter the number of elements store in the array: ");
        number=int.Parse(Console.ReadLine());
        
        int[] value=new int[number];

        for(int i=0;i<number;i++)
        {
            Console.Write($"element - {i} : ");
            value[i]=int.Parse(Console.ReadLine());
            
        }

         Console.Write("The value store in the array in reverse order is: ");
         for(int k=0;k<number;k++)
         {
            Console.Write(value[k]+ " ");
         }

         Console.WriteLine(" ");
         Console.Write("The value store in the array in reverse order is: ");
        for(int j=number-1; j>=0; j--)
        {
          Console.Write(value[j]+" ");
        }
         
    }
    
}
