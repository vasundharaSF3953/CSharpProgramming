using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
      Console.Write("Enter the first Integer:");  
      int a=int.Parse(Console.ReadLine());

      Console.Write("Enter the second Integer:");  
      int b=int.Parse(Console.ReadLine());

      Console.WriteLine("Enter any of the number 1.addition 2.subtraction 3.Multiplication 4.Division 5.Exit");  
      int choice=int.Parse(Console.ReadLine());

      switch(choice)
      {
        case 1:
        {
        int add=a+b;
        Console.WriteLine(add);  
        break;
        }

         case 2:
        {
        int sub=a-b;
        Console.WriteLine(sub); 
        break;
        }
       case 3:
        {
        int mul=a*b;
        Console.WriteLine(mul);  
        break;
      }
       case 4:
        {
        int div=a/b;
        Console.WriteLine(div);
        break;
      }
       case 5:
        {
         
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
