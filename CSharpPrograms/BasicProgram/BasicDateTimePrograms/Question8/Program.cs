using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the date in MM/dd/yyyy format:");
        DateTime date1=DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",null);

        Console.WriteLine("1:"+ date1.ToShortDateString()+ "is lesser than  "  +date1.Month+"/"+date1.Day+"/"+(date1.Year-1));
        Console.WriteLine("-1:"+ date1.ToShortDateString()+ "is lesser than  "  +(date1.AddYears(1).ToShortDateString())); 
    }
}
