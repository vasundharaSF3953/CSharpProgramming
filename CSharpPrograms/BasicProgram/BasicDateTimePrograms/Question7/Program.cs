using System;
namespace Question7;
class  Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any date in dd/MM/yyyy hh:mm:ss tt format:");
        DateTime date1=DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm:ss tt",null);
        
        Console.WriteLine("Enter any date in dd/MM/yyyy hh:mm:ss tt format:");
        DateTime date2=DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm:ss tt",null);

        if(date1==date2)
        {
            Console.WriteLine($"{date1} same as {date2} ");
        }
        else if(date1>date2)
        {
           Console.WriteLine($"{date1} is greater than {date2} "); 
        }
        else
        {
           
           Console.WriteLine($"{date1} is earlier than {date2} "); 
        }

    }
}