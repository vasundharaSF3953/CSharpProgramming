using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        int count=0, special=0,number=0;
        Console.WriteLine("Enter any string: ");
        string data=Console.ReadLine();

        int data2=data.Length;

        for(int i=0;i<data2;i++)
        {
           if((data[i]>='a' && data[i]<='z') || (data[i]>='A' && data[i]<='Z'))
           {
            count=count+1;
           }
           else if(data[i]>='0')
           {
             number=number+1;
           }
           else
           {
             special=special+1;
           }
       
        }

         Console.WriteLine("Number of alphabets in the string is: "+count);
         Console.WriteLine("Number of digits in the string is: "+number);
         Console.WriteLine("Number of special character in the string is : "+special);


        
    }
}
