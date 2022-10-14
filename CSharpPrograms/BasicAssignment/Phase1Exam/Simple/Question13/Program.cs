using System;
namespace Question13;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter which table need to display:");
        int table=int.Parse(Console.ReadLine());

        Console.Write("Enter upto which range need to display:");
        int range=int.Parse(Console.ReadLine());

        for(int i=1;i<=20;i++)
        {
            int multiply=table*i;
            Console.WriteLine($"{table}*{i}="+multiply);
        }
        
        
    }
}
