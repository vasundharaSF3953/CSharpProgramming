using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int sum=0;
        
        for(int i=1;i<=10;i++)
        {
            Console.WriteLine("Enter number:" );
            int n=int.Parse(Console.ReadLine());
            sum=sum+i;
            
        }
        float average=(float)sum/10*100;
        
         Console.WriteLine($"Sum: {sum}");
         Console.WriteLine($"Average: {average}");
    }
}
