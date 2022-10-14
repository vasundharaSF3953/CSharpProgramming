using System;
namespace Question11;
class Program
{
    public static void Main(string[] args)
    {
        string value="";
        Console.WriteLine("Enter any string:");
        string data=Console.ReadLine();
        
        for(int i=0;i<data.Length;i++)
        {
            if(!value.Contains(data[i]))
            {
                value=value+data[i];
            }
        }
        Console.WriteLine("After removing duplicate character from the said string is :"+value);

    }
}
