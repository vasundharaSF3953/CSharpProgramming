using System;

namespace Question20;

class Program
{
    public static void Main(string[] args)
    {
           Console.Write("Enter any number to made Rhombus: ");
           int number= int.Parse(Console.ReadLine());

           int i,j,k;
          //  for(i=1; i<=number; i++)
          //  {
          //    for(j=1; j<=number-i; ++j)
          //     {
          //       Console.Write(" ");
          //     }
          //    for(k=1; k<=i; ++k)
          //     {
          //       Console.Write("* ");
          //     }
          //      Console.WriteLine();
          //  }

          for(i=number; i<=1; i--)
           {
            for(k=1; k<=number; ++k)
              {
                Console.Write("* ");
              }
               Console.WriteLine();
            
              for(j=1; j<=i; ++j)
              {
                Console.Write(" ");
              }
           }

    }
}
