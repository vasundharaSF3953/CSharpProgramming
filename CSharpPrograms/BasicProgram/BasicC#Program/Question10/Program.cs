using System;
namespace Question10;

class Program
{
    public static void Main(string[] args)
    {
        int value1=15;
        int value2=20;

        Console.WriteLine(value1>value2);
        Console.WriteLine(value1<value2);
        Console.WriteLine(value1>=value2);
        Console.WriteLine(value1==value2);
        Console.WriteLine(value1!=value2);
        Console.WriteLine(value1<=value2);
        Console.WriteLine(value1>=10 && value2>=10);
        Console.WriteLine(value1>=10 || value2>=30);
        Console.WriteLine(!(value1>20));
        Console.WriteLine( value1 ==15?"true":"false");
        Console.WriteLine(value1++);
        Console.WriteLine(value1--);

    }
}