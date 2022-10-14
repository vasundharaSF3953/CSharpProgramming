using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of rows:");
        int row=int.Parse(Console.ReadLine());

        int i,j;
        for(i=0;i<row;i++)
        {
            Console.WriteLine(" ");
            for(j=0; j<=i;j++)
            {
               Console.Write("*" );
               
            }
        }
        
    }

}
