using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
       
        Console.WriteLine("Enter any date in dd/MM/yyyy HH:mm:ss tt:");
        DateTime data=DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm:ss tt",null);

         Console.WriteLine("Complete date: "+data.ToString("dd/MM/yyyy HH:mm:ss tt"));
         Console.WriteLine("Short date: "+data.ToShortDateString());
         Console.WriteLine(data.ToLongDateString()+ " " +data.ToString("HH:mm:ss tt") );
         Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss tt"));
         Console.WriteLine(data.ToString("dd/MM/yyyy "));
         Console.WriteLine(data.ToString("HH:mm:ss tt"));
        
    }
}
