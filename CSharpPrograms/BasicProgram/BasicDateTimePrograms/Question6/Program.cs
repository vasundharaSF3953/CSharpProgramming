using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
       DateTime today=DateTime.Now;
       DateTime data=today.AddDays(40);
       Console.WriteLine("Today="+today.ToString("MM/dd/yyyy HH:mm:ss tt"));
       Console.WriteLine(data.DayOfWeek);


    }
   
    
}
