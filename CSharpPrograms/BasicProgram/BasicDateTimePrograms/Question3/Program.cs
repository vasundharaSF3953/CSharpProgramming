using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter the date in dd/MM/yyyy hh:mm:ss tt format: ");
       DateTime data=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
       
      
       Console.WriteLine("Year="+data.Year);
       Console.WriteLine("Month="+data.Month);
       Console.WriteLine("Day="+data.Day);
       Console.WriteLine("Hour="+data.Hour);
       Console.WriteLine("Minute="+data.Minute);
       Console.WriteLine("Seconds="+data.Second);
       Console.WriteLine("Seconds="+data.Millisecond);
    }
    
}
