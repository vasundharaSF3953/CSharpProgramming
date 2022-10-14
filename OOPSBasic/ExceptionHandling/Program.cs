using System;
namespace ExceptionHandeling;

class Program
{
   public static void Main(string[] args)
   {

    try{
         int number1, number2;
         int[] value=new int[1];
         
        Console.WriteLine("Enter First Number: ");
        number1=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second Number: ");
        number2=int.Parse(Console.ReadLine());

        int number=number1/number2;
        Console.WriteLine(number);
    }
    catch(DivideByZeroException e)
    {
        Console.WriteLine("An Exception Occured:", e.Message);
        Console.WriteLine(e.StackTrace);
    }
    catch(FormatException e)
    {
        Console.WriteLine("An Exception Occured:", e.Message );
        Console.WriteLine(e.StackTrace);
    
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message );
        Console.WriteLine(e.StackTrace);  
    }
    finally
    {
        Console.WriteLine("All Exceptions handled properly");
    }
    
    

        
        
   }
}