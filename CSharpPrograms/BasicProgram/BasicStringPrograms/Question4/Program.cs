using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any string:");
        string data=Console.ReadLine();
        
        string[] splitWord=data.Split(new string[] {" "},StringSplitOptions.None);

        int count=splitWord.Length;

        Console.WriteLine("The number of words in the string is: "+count);
    }
}
