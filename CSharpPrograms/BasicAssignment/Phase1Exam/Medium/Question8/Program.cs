using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any string:");
        string data=Console.ReadLine();
        char[] data2=data.ToCharArray();
        
        int value=data2.Length;
        int number=0;
        
        
        for(int i=0;i<value;i++)
        {
            if(data2[i]>='0' && data2[i]<='9')
            {
                number=number*10+data2[i]-'0';
            }
        }
        if(number%2==0)
        {
           Console.WriteLine($"{number} is even number"); 
        }
    }
}
