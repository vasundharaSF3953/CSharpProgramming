using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the start year:");
        DateTime year1=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);

        Console.Write("Enter the end year:");
        DateTime year2=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);

        for(int i=year1.Year; i<=year2.Year; i++)
        {
            if(DateTime.IsLeapYear(i))
            {
               Console.WriteLine($"{i} is a leap year");
               DateTime leapYear=new DateTime(i,2,29);
               DateTime nextYear=leapYear.AddYears(1);
               Console.WriteLine($"    One year from {leapYear.ToString("MM/dd/yyyy")} is {nextYear.ToString("MM/dd/yyyy")}");
            }
        }
        
    }
}
