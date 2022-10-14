using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter any of the character E V G A F");  
      Char choice=char.Parse(Console.ReadLine());

      switch(choice)
      {
        case 'E':
        {
        Console.WriteLine("Excelent");  
        break;
        }

         case 'V':
        {
        Console.WriteLine("Very Good");  
        break;
        }
       case 'G':
        {
        Console.WriteLine("Good");  
        break;
      }
       case 'A':
        {
        Console.WriteLine("Average");  
        break;
      }
       case 'F':
        {
        Console.WriteLine("Fail");  
        break;
      }
      default:
      {
          Console.WriteLine("Enter only between these charcters");  
          break;
      }
      }
    }
}

