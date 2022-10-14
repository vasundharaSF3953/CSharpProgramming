using System;

namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the amount in Rs:");
        int amount=int.Parse(Console.ReadLine()); 

        double usd=(double)amount*1.22;
        double eur=(double)amount*1.27;
        double cny=(double)amount*8.79;

        Console.WriteLine($"The Rs {amount} is converted into USD currencies is :"+usd);
        Console.WriteLine($"The Rs {amount} is converted into EUR currencies is :"+eur);
        Console.WriteLine($"The Rs {amount} is converted into CNY currencies is :"+cny);
    }
   
    
}
