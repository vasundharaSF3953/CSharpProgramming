using System;
namespace ByNoOfArguments;
class Program
{

   //Method with one parameter
   static void Display(int number)
   {
     Console.WriteLine("Arguments:"+number);
   }

   //Method with two Parameter
    static void Display(int number1, int number2)
    {
        Console.WriteLine("Arguments:"+number1+"and"+number2);
    }
    public static void Main(string[] args)
    {
       Display(50);
       Display(10,20); 
    }
}
