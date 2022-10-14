using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any string:");
        string data=Console.ReadLine();
        
        int count=0;
        foreach(char i in data)
        {
            Console.Write(i);
            count++;
        }
        Console.WriteLine(" ");
        Console.WriteLine("The length of the string:"+count);
    }
} 
