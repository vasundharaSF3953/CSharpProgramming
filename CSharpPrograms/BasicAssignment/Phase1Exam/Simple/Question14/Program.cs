using System;
namespace Question14;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number of rows:");
        int rows=int.Parse(Console.ReadLine());

        for(int i=1;i<=rows;i++)
        {
            Console.WriteLine("");
            for(int j=1;j<=i;j++)
            {

                Console.Write(i);
            }
        }
        
    }
}
