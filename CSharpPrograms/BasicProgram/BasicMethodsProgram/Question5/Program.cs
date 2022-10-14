using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        int number,count=0;
        Console.Write("Enter the number:");
        number=int.Parse(Console.ReadLine());
        PrimeNumber(number);

        void PrimeNumber(int value)
        {
            for(int i=1;i<=value;i++)
            {
                if(number%i==0)
                {
                   count=count+1;
                }
            }
            if(count==2)
            {
               Console.Write($"{value} is a prime number");
                 
            }

        }
        

    }
}
