using System;
namespace Question11;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number for x:");
        int number1=int.Parse(Console.ReadLine());

        Console.Write("Enter number for y:");
        int number2=int.Parse(Console.ReadLine());

        int power=1;
        for(int i=1; i<=number2;i++)
        {
            power=power*number1;
        }
        Console.WriteLine("The x power y is:"+power);
        
    }
}
