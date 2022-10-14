using System;
namespace Question2;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the first number: ");
        int num1=int.Parse(Console.ReadLine());

        Console.WriteLine("Input the second number: ");
        int num2=int.Parse(Console.ReadLine());

        int add=num1+num2;

        int sub=num1-num2;

        int multiply=num1*num2;

        int divide=num1/num2;

        int modulo=num1%num2;

        Console.WriteLine($"{num1} + {num2} = {add}");
        Console.WriteLine($"{num1} - {num2} = {sub}");
        Console.WriteLine($"{num1} x {num2} = {multiply}");
        Console.WriteLine($"{num1} / {num2} = {divide}");
        Console.WriteLine($"{num1} % {num2} = {modulo}");

    }
}