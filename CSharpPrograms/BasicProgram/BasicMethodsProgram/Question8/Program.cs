using System;
namespace Question8;
class Program
{
   public static void Main(string[] args)
   {

     int mark1,mark2,mark3;
     Console.WriteLine("Enter your first subject mark:");
     mark1=int.Parse(Console.ReadLine());

    Console.WriteLine("Enter your second subject mark:");
    mark2=int.Parse(Console.ReadLine());

     Console.WriteLine("Enter your third subject mark:");
     mark3=int.Parse(Console.ReadLine());
     Percentage(mark1,mark2,mark3);

     void Percentage(int a,int b,int c)
     {
        int percent,sum;
        sum=a+b+c;
        percent=sum/300*100;
        Console.WriteLine($"Mark1: {a}");
        Console.WriteLine($"Mark2: {b}");
        Console.WriteLine($"Mark3: {c}");
        Console.WriteLine($"Percentage: {percent}");
     }


     
   }
}
