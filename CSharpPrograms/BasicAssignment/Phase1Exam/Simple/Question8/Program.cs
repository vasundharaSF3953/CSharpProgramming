using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the speed of the vehicle:");
        double speed=double.Parse(Console.ReadLine());

        int data=(int)speed;
        Console.WriteLine(data);

        if(data<=10)
        {
            Console.WriteLine("Slow");
        }
        else if(data>10 || data<=50)
        {
            Console.WriteLine("average");
        }
        else if(data>50 || data<=150)
        {
            Console.WriteLine("fast");
        }
        else if(data>150 || data<=1000)
        {
            Console.WriteLine("ultra fast");
        }
        else
        {
           Console.WriteLine("extremely fast");
        }
        
    }
}
