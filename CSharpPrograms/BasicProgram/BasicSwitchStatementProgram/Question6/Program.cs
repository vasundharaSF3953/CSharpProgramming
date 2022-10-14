using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
      
      Console.WriteLine("Enter the radius of the circle: ");  
      int radius=int.Parse(Console.ReadLine());

      Console.WriteLine("Enter any of the choices 1.area 2.perimeter 3.Diameter");  
      int choice=int.Parse(Console.ReadLine());

      switch(choice)
      {
        case 1:
        {
        double area=3.14*(double)radius*radius;
        Console.WriteLine($"The area is :{area} ");  
        break;
        }
         case 2:
        {
        double perimeter=2*3.14*(double)radius;
        Console.WriteLine($"The perimeter is :{perimeter} ");  
        break;
        }

         case 3:
        {
         double diameter=2*radius;
         Console.WriteLine($"The diameter is :{diameter} ");  
    
        break;
        }
       
       
      default:
      {
          Console.WriteLine("You have entered wrong choice");  
          break;
      }
      }  
    }
}
