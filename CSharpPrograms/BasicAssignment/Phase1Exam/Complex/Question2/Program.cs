using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of series:");
        int series=int.Parse(Console.ReadLine());

        double number=1;
        int data=1+2+2*2;
        for(int i=2;i<series;i++)
        {
            
          number=i!+2*i+1/number;
        }
        number=data/number/series!;
       Console.WriteLine(number); 
        
    }
}
