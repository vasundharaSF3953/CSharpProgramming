using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first string:");
        string data1=Console.ReadLine();
        
        Console.Write("Enter the second string:");
        string data2=Console.ReadLine();

        if(data1==data2)
        {
          Console.WriteLine("The length of both strings are equal and also, both strings are equal");  
        }
        else
        {
           Console.WriteLine("The both string are not equal");   
        }
    }
}
