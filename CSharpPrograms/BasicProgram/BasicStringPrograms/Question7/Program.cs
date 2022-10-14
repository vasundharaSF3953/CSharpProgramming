using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
         string data="";
         int count=0,constant=0,space=0;
        Console.Write("Enter any string: ");
         data=Console.ReadLine();
        
        int value=data.Length;

        for(int i=0;i<value;i++)
        {
            if(data[i]=='a'|| data[i]=='e'|| data[i]=='i'|| data[i]=='o'|| data[i]=='u' || data[i]=='A'|| data[i]=='E'|| data[i]=='I'|| data[i]=='O'|| data[i]=='U')
            {
                count=count+1;
            }
            else if((data[i]>='a' && data[i]<='z') ||  (data[i]>='A' && data[i]<='Z'))
            {
                constant=constant+1;
                space=space+1;
            }
            else
            {
                space=space+1;
            }
        }

        Console.WriteLine("Total number of vowels in the string is string: "+count);
        Console.Write("Total number of constant in the string is string: "+constant);
    }
}
