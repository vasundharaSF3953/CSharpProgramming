using System;
namespace Question13;
class Program
{
    public static void Main(string[] args)
    {
        int sum=0;
        Console.Write("Enter any string: ");
        string data=Console.ReadLine();
        
        int count=data.Length;
        Console.WriteLine(count);


        
        

        for(int i=0;i<count;i++)
        {

           
            if(data[i]>='0'&& data[i]<='9')
            {
               sum=sum+data[i]-'0';
             
            }
        }
          Console.WriteLine(sum);
    }
}