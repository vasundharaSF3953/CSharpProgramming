using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the start year:");
        DateTime year1=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        
        Console.Write("Enter the End year:");
        DateTime year2=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);

       

        for(int i=year1.Year;i<=year2.Year;i++)
        {
            DateTime date1=new DateTime(i,01,01,00,00,00);
            DateTime date2=new DateTime(i,12,31,00,00,00);
            TimeSpan span=date2-date1;
            Console.WriteLine($"12/31/{i}: day "+((int)span.TotalDays+1)+" Of " +i);
            
        }
    }
}
