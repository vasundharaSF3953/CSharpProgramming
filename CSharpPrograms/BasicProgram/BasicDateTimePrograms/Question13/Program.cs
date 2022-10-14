using System;
namespace Question13;
class Program
{
    public static void Main(string[] args)
    {
       Console.Write("Enter any day:");
       DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd",null);
       

       Console.Write("Enter any Month:");
       DateTime month1=DateTime.ParseExact(Console.ReadLine(),"MM",null);

       Console.Write("Enter any Year:");
       DateTime year1=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);

       DateTime date2=new DateTime(year1.Year,month1.Month,date1.Day,00,00,00);
       Console.WriteLine(date2);

       if(date2.DayOfWeek==DayOfWeek.Sunday)
       {
          date2=date2.AddDays(6);
          Console.WriteLine($"The last day of the week for the above date is: {date2.ToString("dd/MM/yyyy")}");
       }
        else if(date2.DayOfWeek==DayOfWeek.Monday)
       {
          date2=date2.AddDays(5);
          Console.WriteLine($"The last day of the week for the above date is: {date2.ToString("dd/MM/yyyy")}");
       }
        else if(date2.DayOfWeek==DayOfWeek.Tuesday)
       {
          date2=date2.AddDays(4);
          Console.WriteLine($"The last day of the week for the above date is: {date2.ToString("dd/MM/yyyy")}");
       }
         else if(date2.DayOfWeek==DayOfWeek.Wednesday)
       {
          date2=date2.AddDays(3);
          Console.WriteLine($"The last day of the week for the above date is: {date2.ToString("dd/MM/yyyy")}");
       }
        else if(date2.DayOfWeek==DayOfWeek.Thursday)
       {
          date2=date2.AddDays(2);
          Console.WriteLine($"The last day of the week for the above date is: {date2.ToString("dd/MM/yyyy")}");
       }
       else if(date2.DayOfWeek==DayOfWeek.Friday)
       {
          date2=date2.AddDays(1);
          Console.WriteLine($"The last day of the week for the above date is: {date2.ToString("dd/MM/yyyy")}");
       }
       else
       {
         Console.WriteLine($"The last day of the week for the above date is: {date2.ToString("dd/MM/yyyy")}");
       }



       

  
       
       
       

       
       
    }
}
