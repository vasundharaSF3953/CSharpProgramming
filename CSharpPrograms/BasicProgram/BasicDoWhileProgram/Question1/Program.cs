using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        string value="";
        do{
            Console.Write("Enter any Number:");
            int num=int.Parse(Console.ReadLine());
            if(num%2==0)
            {
              Console.WriteLine("Given number is even number");  
            }
            else{
               Console.WriteLine("Given number is odd number"); 
            }
            Console.WriteLine("Do you want to continue:");
            value=Console.ReadLine();
            
             
          }while(value=="yes");

          
    }
}
