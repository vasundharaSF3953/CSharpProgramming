using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of rows:");
        int rows=int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns:");
        int columns=int.Parse(Console.ReadLine());

        for(int i=1;i<=rows;++i)
        {
            for(int j=1;j<=rows-i;++j)
            {
             Console.Write(" ");
            }
            for(int k=1;k<=i;++k)
            {
                Console.Write("*" );
            }
            Console.WriteLine("");
        
        }
        
    }
}
