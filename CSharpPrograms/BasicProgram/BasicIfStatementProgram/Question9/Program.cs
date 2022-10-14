using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter any month"); 
       string month=Console.ReadLine();
       
       if(month == "December" || month =="January" || month == "February" )
       {
         Console.WriteLine("winter"); 
       }
       else if(month == "March" || month =="April" || month == "May" )
       {
        Console.WriteLine("spring");
       }
       else if(month == "June" || month =="July" || month == "August" )
       {
        Console.WriteLine("summer");
       }
         else if(month == "September" || month =="October" || month == "November" )
       {
        Console.WriteLine("rainfall");
       }
       else
       {
        Console.WriteLine("You have enter the wrong month name");
       }
    }
}
