using System;
namespace WhileLoopAssignment;
class Program
{
    public static void Main(string[] args)
    {
       
        int num=0; 
         while(num<=25)
         {
            if(num%2==0)
            {
               Console.WriteLine(num); 
            }
            num++;

         }
 
        int a;
        Console.Write("Enter the number:");
        bool num1=int.TryParse(Console.ReadLine(),out a);
        
        
          while(!num1)
        {
           
            Console.WriteLine("You have enter the invalid number"); 
            Console.Write("Enter the number:");
             num1=int.TryParse(Console.ReadLine(),out a);
            

        }
         Console.WriteLine(a);

             
            
            
            
          
        


       

       


    }
}
