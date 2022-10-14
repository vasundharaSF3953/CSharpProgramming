using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of elements to be stored in the array:");
        int number=int.Parse(Console.ReadLine());

        int[] array=new int[number];

        for(int i=0;i<number;i++)
        {
            Console.Write($"element-{i}:");
            array[i]=int.Parse(Console.ReadLine());
            
        }

        int temp;
        for(int i=0;i<number;i++)
        {
            for(int j=0;j<number;j++)
            {
               if(array[i]<array[j]) 
               {
                temp=array[i];
                array[i]=array[j];
                array[j]=temp;

               }
            }
        }
        
       
        Console.WriteLine("The Minimun element is:"+array[number-1]);
        Console.WriteLine("The Maximum element is:"+array[0]);
        
    }
}
