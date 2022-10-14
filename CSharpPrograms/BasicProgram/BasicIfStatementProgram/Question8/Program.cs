using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter Your Sugar Level"); 
       int sugarLevel=int.Parse(Console.ReadLine());
       
       if(sugarLevel<90)
       {
         Console.WriteLine("Low Sugar"); 
       }
       else if(sugarLevel>=90 && sugarLevel<130)
       {
        Console.WriteLine("Normal");
       }
       else if(sugarLevel>=130 && sugarLevel<140)
       {
        Console.WriteLine("Medium");
       }
        else if(sugarLevel>=140 && sugarLevel<170)
       {
        Console.WriteLine("High Sugar. Try to reduce it from now");
       }
       else
       {
        Console.WriteLine("You are a very high Sugar parent");
       }
    }
}

