using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the lower limit:");
        int lower=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the upper limit:");
        int upper=int.Parse(Console.ReadLine());


       
        

        for(int i=lower;i<=upper;i++)
        {
            int data=i;
            int value=i;
            int rem=0,temp;
            while(value>0)
            {
                temp=i%10;
                rem=temp*temp*temp+rem;
                value=value/10;
           }
            if(rem==data)
            {
                Console.Write(rem+",");
            }

        }
        
    }
}
