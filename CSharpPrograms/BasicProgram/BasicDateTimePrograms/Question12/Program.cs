using System;
namespace Question12;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any month in number:");
        DateTime month1=DateTime.ParseExact(Console.ReadLine(),"MM",null);

        Console.Write("Enter any year in number:");
        DateTime year1=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);

        int numberOfDays=DateTime.DaysInMonth(year1.Year,month1.Month);
      
        Console.WriteLine($"The number of days in {month1.ToString("MMMM")} is : {numberOfDays}");

        
    }
}
