using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
         Console.Write("Enter a number: ");
         int number1=int.Parse(Console.ReadLine());

         Console.Write("Enter another number: ");
         int number2=int.Parse(Console.ReadLine());

         Swap(number1,number2);

         //with argument without return type
          void Swap(int data1,int data2)
          {
            data1=data1+data2;
            data2=data1-data2;
            data1=data1-data2;
            Console.WriteLine($"Now the first number is: {data1}, and the second number is: {data2}");





          }


         
    }
}
