using System;
namespace DoWhileAssignment;
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
              Console.WriteLine("Number is even");  
            }
            else{
               Console.WriteLine("Number is odd"); 
            }
            Console.WriteLine("Do you want to continue:");
            value=Console.ReadLine();
            while(value!="yes" && value!="no")
            {
              Console.WriteLine("You have enter the wrong input");  
              Console.WriteLine("Do you want to continue:");
              value=Console.ReadLine();  
            }
             
          }while(value=="yes");

          
    }
}

