using System;
namespace Question6;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the temperature:");
        int temp=int.Parse(Console.ReadLine());
        
        if(temp<=0)
        {
            Console.WriteLine("Freezing Weather");
        }
        else if(temp>0 && temp<=10)
        {
            Console.WriteLine("Very Cold Weather");
        }
        else if(temp>10 && temp<=20)
        {
            Console.WriteLine("Cold Weather");
        }
        else if(temp>20 && temp<=30)
        {
            Console.WriteLine("Normal in Temp");
        }
        else if(temp>30 && temp<=40)
        {
            Console.WriteLine("Its Hot");
        }
        else
        {
            Console.WriteLine("Its Very Cold");
        }

    }
}