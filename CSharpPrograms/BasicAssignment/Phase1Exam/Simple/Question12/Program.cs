using System;
namespace Question12;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the range:");
        int range=int.Parse(Console.ReadLine());
        int sum=0;

        for(int i=1;i<=99;i++)
        {
            if(i%2!=0)
            {
               sum=sum+i*i;
            }
        }
        
        Console.WriteLine($"The sum of square od odd value range from 1 to {range} is: "+sum);
        
    }
}
