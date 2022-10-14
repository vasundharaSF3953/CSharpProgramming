using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any string:");
        string data=Console.ReadLine();
        
        int value=data.Length;

        
        char data2=' ';
        for(int i=0;i<value;i++)
        {
            if(data[i]>='1' || data[i]<='9')
            {
                data2=data[i];
            }
        }
        if(data2%2==0)
        {
           Console.WriteLine(data2+" is even number"); 
        }
    }
}
