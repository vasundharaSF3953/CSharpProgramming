using System;
namespace Question7;

class Program
{
    public static void Main(string[] args)
    {
        string data,data1="";
        int b;
        System.Console.WriteLine("Enther the string");
        data=Console.ReadLine();
        Palindrome(data);

        void Palindrome(string s)
        {
             b=s.Length;
            for(int i=b-1;i>=0;i--)
            {
                 data1=data1+s[i];
            }
            if(data1==data)
            {
                System.Console.WriteLine("The string is palindrome");
            }
            else
            {
                 System.Console.WriteLine("The string is not a palindrome"); 
            }

        }
        
    }
}
