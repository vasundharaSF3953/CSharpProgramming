using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        int number;
        Console.Write("Enter the size array: ");
        number=int.Parse(Console.ReadLine());
        
        int[] value=new int[number];

        for(int i=0; i<number;i++)
        {
            Console.Write($"element-{i}: ");
            value[i]=int.Parse(Console.ReadLine());
            
        }
        Console.Write("Elements of array in sorted ascending order: ");

        for(int i=0; i<number; i++)
        {
            for(int j=0;j<number;j++)
            {
                if(value[i]<value[j])
                {
                    int temp=value[i];
                    value[i]=value[j];
                    value[j]=temp;


                    
                }
            }
        }  

        for(int i=0; i<number;i++)
        {
            Console.Write(value[i]+" ");
        }


    }
}
