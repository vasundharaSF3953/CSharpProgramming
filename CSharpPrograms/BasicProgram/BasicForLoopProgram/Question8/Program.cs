using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter number of rows need to print:");
        int value=int.Parse(Console.ReadLine());
        int i,j,k,count=0;
        for(i=1;i<=value;++i)
        {
          for(j=1;j<=value-i;++j)
            {
             Console.Write(" ");
            }     
            for( k=1;k<=i;++k)
            {
                int data=count+1;
                Console.Write($"{data} ");
                count++;
            }
            Console.WriteLine();
        }
    }
        
}
