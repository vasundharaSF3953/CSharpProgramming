using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the date in dd/MM/yyyy format:");
        DateTime data=DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",null);
        Console.WriteLine($"The day of the week for {data.ToString("dd/MM/yyyy")} is "+data.DayOfWeek);
        
    }
}
