using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
      

      Console.WriteLine("Enter any of the country name India Pakistan Bangladesh");  
      string choice=Console.ReadLine();

      switch(choice)
      {
        case "India":
        {
        
        Console.WriteLine("1. Gambir"); 
        Console.WriteLine("2. Awshin");  
        Console.WriteLine("3. Dhoni");
        Console.WriteLine("4. Jadeja"); 
        break;
        }

         case "Pakistan":
        {
        
        Console.WriteLine("1. Babar Azam"); 
        Console.WriteLine("2. Imran Khan");  
        Console.WriteLine("3. Shami");
        Console.WriteLine("4. Axar Patel");  
        break;
        }
       case "Bangladesh":
        {
        
        Console.WriteLine("1. Sachin"); 
        Console.WriteLine("2. Virat Kohli");  
        Console.WriteLine("3. Yadav");
        Console.WriteLine("4. KL Rahul");  
        break;
      }
       
      default:
      {
          Console.WriteLine("You have entered wrong country name");  
          break;
      }
      }  
    }
}
