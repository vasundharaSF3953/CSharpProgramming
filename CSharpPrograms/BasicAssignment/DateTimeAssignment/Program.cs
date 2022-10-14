using System;
namespace DateTimeAssignment;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2021,8,10,10,40,32);
        Console.WriteLine(date.Year);
        Console.WriteLine(date.Month);
        Console.WriteLine(date.Day);
        Console.WriteLine(date.Hour);
        Console.WriteLine(date.Minute);
        Console.WriteLine(date.Second);


        string date1= date.ToString("yyyy/MM/dd hh:mm:ss tt");
        
        string[] date2=date1.Split('/',':',' ');
       
        int size=date2.Length;
        Console.WriteLine(size);
        for(int i=size-1; i>=0; i--)
        {
            Console.Write(date2[i]+ " ");
        }
        

      
        Console.WriteLine(" ");
        Console.WriteLine("Enter your date of birth in dd/MM/yyyy hh:mm:ss tt format");
        DateTime date3=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        Console.WriteLine(date3.Date);
        Console.WriteLine(date3.Month);
        Console.WriteLine(date3.Year);
       
         


        

    }
}