using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        int number;
        Console.Write("Enter the number of elements to be stored in the array: ");
        number=int.Parse(Console.ReadLine());
        
        int[] value=new int[number];

        for(int i=0; i<number;i++)
        {
            Console.Write($"element-{i}: ");
            value[i]=int.Parse(Console.ReadLine());
            
        }

        Console.WriteLine("The Even elements are ");
        for(int i=0; i<number;i++)
        {
            if(value[i]%2==0)
            {
                Console.Write(value[i]+" ");
            }
            
        }

        Console.WriteLine(" ");
        Console.WriteLine("The odd elements are ");
        for(int i=0; i<number;i++)
        {
            if(value[i]%2!=0)
            {
                Console.Write(value[i]+" ");
            }
            
        }

    }
}
