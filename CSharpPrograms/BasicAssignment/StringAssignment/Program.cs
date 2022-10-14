using System;
namespace StringAssignment;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the main string:");
        string word1=Console.ReadLine();

        Console.Write("Enter any substring:");
        string word2=Console.ReadLine();

        
      
        string[] word3=word1.Split(new string[] {word2},StringSplitOptions.None);

        int length=word3.Length-1;

         
        Console.WriteLine($"String searched count is {length}");
        

        
 
        
        
        
    }
}
