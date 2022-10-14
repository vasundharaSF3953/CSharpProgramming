using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
       
        int number,sum=0;
        Console.Write("Enter the number of elements store in the array: ");
        number=int.Parse(Console.ReadLine());
        
        int[] value=new int[number];

        for(int i=0;i<number;i++)
        {
            Console.Write($"element - {i} : ");
            value[i]=int.Parse(Console.ReadLine());
            
        }

         for(int j=0;j<number;j++)
        {
            sum=sum+value[j];
        }
        Console.WriteLine($"Sum of all elements stored in the array is: {sum}");
         
         
    }
    
}
