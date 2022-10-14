using System;
namespace Question8;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any string: ");
        string stringData=Console.ReadLine();
        
         Console.Write("Enter the position to start extraction: ");
         int position=int.Parse(Console.ReadLine());

         Console.Write("Enter the length of substring: ");
         int length=int.Parse(Console.ReadLine());

         int count=position+length;
   
         
         Console.Write("The substring retrieve from the string is: ");
         for(int i=position;i<count;i++)
         {
            Console.Write(stringData[i]);
         }
         

    }
}