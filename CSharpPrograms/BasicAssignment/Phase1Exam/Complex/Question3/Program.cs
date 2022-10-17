using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first text:");
        string text1=Console.ReadLine();

        Console.Write("Enter the second text:");
        string text2=Console.ReadLine();

        int value=text1.Length;

        int count=0;
        for(int i=0;i<value;i++)
        {
            for(int j=0;j<value;j++)
            {
            if(text1[i]==text2[j])
            {
               count=count+1;
            }
        }
        
      }
      if(count==value)
        {
            Console.WriteLine("Name one and two are Anagrams");
        }
        else
        {
            Console.WriteLine("Name one and two are not Anagrams");
        }
    }
}
