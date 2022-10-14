using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int value1=int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int value2=int.Parse(Console.ReadLine());
         Addition();
         Subtraction();
         Multiplication();
         Division();

        void Addition()
            {
              int add;
              add=value1+value2;
              Console.WriteLine("Addition: "+add);
            }
        void Subtraction()
           {
             int subtract;
             subtract=value1-value2;
             Console.WriteLine("Subtraction: "+subtract);
           } 
       void Multiplication()
          {
             int multiply;
             multiply=value1*value2;
             Console.WriteLine("Multiplication: "+multiply);
          }

       void Division()
          {
            int divide;
            divide=value1/value2;
            Console.WriteLine("Division: "+divide);
          }   
        
    }
}