using System;
namespace Question5;
 class Program
 {
    public static void Main(string[] args)
    {
        Console.Write("Enter any string:");
        string  data=Console.ReadLine();
        
        int value=data.Length;
        Console.WriteLine(value);

        char[] array=data.ToCharArray();

        string data1="";
        for(int i=value-1;i>=0;i--)
        {
           
           data1=data1+array[i];
        }

        if(data==data1)
        {
            Console.WriteLine($"{data} is a palindrome");
        }
    }
 }
