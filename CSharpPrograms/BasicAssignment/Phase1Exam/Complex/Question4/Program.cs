using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any string:");
        string text=Console.ReadLine();
        
        int value=text.Length;
        // string data1="";

        for( int i=0; i<=value-2;i++)
        {
            for(int j=1;j<value;j++)
            {
                if(text[i]==text[j])
                {
                  
                }
            }
        }
    }
}
