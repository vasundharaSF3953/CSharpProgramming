using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter number of rows need to print:");
        int value=int.Parse(Console.ReadLine());
        int i,j,k;
        for(i=1;i<=value;++i)
        {
          for(j=1;j<=value-i;++j)
            {
             Console.Write(" ");
            }     
            for( k=1;k<=i;++k)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
        
}
