using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the string: ");
        string data=Console.ReadLine();
        
        int value=data.Length;

        Console.WriteLine("The characters of the string are: ");
        for(int i=0;i<value;i++)
        {
            Console.Write(data[i]+" ");
        }
    }
}
