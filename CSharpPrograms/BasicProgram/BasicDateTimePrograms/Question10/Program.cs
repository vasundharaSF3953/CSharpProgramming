using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date1=DateTime.Now;
        DateTime date2=date1.AddDays(1);
        DateTime date3=date1.AddDays(-1);
        Console.WriteLine("yesterday:"+date2.ToString("dd/MM/yyyy"));
        Console.WriteLine("Tomorrow:"+date3.ToString("dd/MM/yyyy"));
    }
}
