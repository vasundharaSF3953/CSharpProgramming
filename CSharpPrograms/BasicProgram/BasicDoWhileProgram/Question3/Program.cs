using System;
namespace Question3;

class Program
{
    public static void Main(string[] args)
    {
        int num=0, n1=0,n2=1,n3, count=2;
        
       
        
        Console.Write("Enter the number of terms: ");
        num=int.Parse(Console.ReadLine());

        
        Console.WriteLine($"Here is the Fibonacci series upto {num} terms :  ");
        Console.Write(n1+ " "+n2+" "); 
        
       
        do
        {
         n3=n1+n2;
         Console.Write(n3+" "); 
         n1=n2;
         n2=n3;
         count=count+1;
         
             

            
        }while(count<num);
        
    }
}
