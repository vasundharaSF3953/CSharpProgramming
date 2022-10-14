using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of Fibonacci Series:");
        int value1=int.Parse(Console.ReadLine());
        Fibonacci(value1);
        
        void Fibonacci(int number1)
        {
            int data1=0,data2=1;
            Console.Write(data1+" "+data2+" ");
            for(int i=2;i<number1;i++)
            {
                int data3=data1+data2;
                Console.Write(data3+" ");
                data1=data2;
                data2=data3;
            }

        }
    }
}
