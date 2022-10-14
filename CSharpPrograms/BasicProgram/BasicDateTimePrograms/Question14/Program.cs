using System;
namespace Question14;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any date of the month:");
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
        Console.Write("Enter number of days leave taken:");
        int leave=int.Parse(Console.ReadLine());

        if(date.Month==02)
        {
            TimeSpan span=new TimeSpan(28,0,0,0);
            int totalDays=span.Days;
            int salary=(totalDays-leave)*500;
            Console.WriteLine("Salary for this month is: "+salary);
        }
        else if(date.Month==01 || date.Month==03 || date.Month==05 || date.Month==07 || date.Month==08 || date.Month==10 || date.Month==12)
        {
            TimeSpan span=new TimeSpan(31,0,0,0);
            int totalDays=span.Days;
            int salary=(totalDays-leave)*500;
            Console.WriteLine("Salary for this month is: "+salary);

        }
        else
        {
             TimeSpan span=new TimeSpan(31,0,0,0);
             int totalDays=span.Days;
             int salary=(totalDays-leave)*500;
             Console.WriteLine("Salary for this month is: "+salary);

        }

        
        
    }
}
