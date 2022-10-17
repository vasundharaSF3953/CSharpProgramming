using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any string:");
        string text=Console.ReadLine();
        
        int value=text.Length;
        string data1="";

        for( int i=0; i<value;i++)
        {
            if(!data1.Contains(text[i] + ""))
            {
                data1+=text[i];
            }
        }
        Console.WriteLine("After removing the duplicate charactes from the said string is: "+data1);
    }
}
