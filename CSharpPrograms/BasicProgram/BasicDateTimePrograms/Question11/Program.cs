using System;
namespace Question11;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the date in dd/MM/yyyy format");
        DateTime currentDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
        

        Console.WriteLine("Display the name of the month of the year");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("The date of today: "+currentDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("The tweleve months are:");

        for(int i=0;i<12;i++)
        {
            
            Console.WriteLine(currentDate.ToString("MMMM"));
            currentDate=currentDate.AddMonths(1);
        }
    }
}
