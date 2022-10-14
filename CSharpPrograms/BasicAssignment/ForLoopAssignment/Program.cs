using System;
namespace ForLoopAssignment;

class Program
{
    public static void Main(string[] args)
    {
        int sum=0;
        for(int i=0;i<=25;i++)
        {
            
            if(i%2==0)
            {
                
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Enter the starting limit:");
        int start=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the end limit:");
        int end=int.Parse(Console.ReadLine());

        for(int i=start; i<=end; i++)
        {
             sum=+i*i;
        }    

       Console.WriteLine($"The Sum is: {sum}");   
        
    }
}