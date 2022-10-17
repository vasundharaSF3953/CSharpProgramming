using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int number=1;
        double data=1.0;
        int num=1;

        Console.Write("Enter the number of series:");
        int series=int.Parse(Console.ReadLine());

      

        for(int i=1;i<=series;i++)
        {
          num=2*num;
          for(int j=i; j<=i; j++)
          {
             number=number*i;
            for(int k=i; k<=i; k++)
            {
               data+=(double)num/number;
            }
           }
        }
        Console.WriteLine("Output is:" +Math.Round(data,4)); 
      }
}
