using System;

namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        int a;
        int temp=0;
        do
        {
            Console.Write("Enter the number: ");
            bool num=int.TryParse(Console.ReadLine(), out a);
       
            if(a>=1 && a<=10)
                {
                  Console.WriteLine(a);
                  temp=1;  
                }
                
            
            
        }while(temp==0);
    }
}
