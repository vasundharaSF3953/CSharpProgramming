using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter any of the number 1 2 3 4 5 6 7 8 9 10 11 12");  
      int choice=int.Parse(Console.ReadLine());

      switch(choice)
      {
        case 1:
        {
        Console.WriteLine("Month have 31 days");  
        break;
        }

         case 2:
        {
        Console.WriteLine("Month have 28 day");  
        break;
        }
       case 3:
        {
        Console.WriteLine("Month have 31 day");  
        break;
      }
       case 4:
        {
        Console.WriteLine("Month have 30 day");  
        break;
      }
       case 5:
        {
        Console.WriteLine("Month have 31 day");  
        break;
      }
      case 6:
        {
        Console.WriteLine("Month have 30 day");  
        break;
      }
      case 7:
        {
        Console.WriteLine("Month have 31 day");  
        break;
      }
      case 8:
        {
        Console.WriteLine("Month have 31 day");  
        break;
      }
      case 9:
        {
        Console.WriteLine("Month have 30 day");  
        break;
      }
      case 10:
        {
        Console.WriteLine("Month have 31 day");  
        break;
      }
      case 11:
        {
        Console.WriteLine("Month have 30 day");  
        break;
      }
      case 12:
        {
        Console.WriteLine("Month have 31 day");  
        break;
      }
      

      default:
      {
          Console.WriteLine("Enter only between this numbers");  
          break;
      }
      }  
    }
}
