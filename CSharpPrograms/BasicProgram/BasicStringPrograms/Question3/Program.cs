using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the string: ");
        string data=Console.ReadLine();
        
        int value=data.Length;

        Console.WriteLine("The characters of the string are: ");
        for(int i=value-1;i>=0;i--)
        {
            Console.Write(data[i]+" ");
        }
    }
}
