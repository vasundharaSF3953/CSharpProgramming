using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        int r=0;
        int a;
        Console.Write("Enter any number: ");
        int n=int.Parse(Console.ReadLine());

        for(a=n; n!=0; n=n/10)
        {
            int b=n%10;
            r=b*b*b+r;
        }
        if(a==r)
        {
        Console.Write($"{r} is an Amstrong Number");
        }
    }
}
