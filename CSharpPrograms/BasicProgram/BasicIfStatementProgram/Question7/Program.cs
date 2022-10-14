using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your customer ID:");
        int id=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your name:");
        string name=Console.ReadLine();

        Console.WriteLine("Enter unit consumed by you:");
        int unit=int.Parse(Console.ReadLine());

        Console.WriteLine($"Customer IDNO : {id}");
        Console.WriteLine($"Customer Name : {name}");
        Console.WriteLine($"unit Consumed : {unit}");

       if(unit>100 && unit<200)
       {
        double a=1.20*(double)unit;
        Console.WriteLine($"Amount Charges @Rs. 1.20 per unit:{a} ");
       }
       else if(unit>=200 && unit<400)
       {
        double a=1.50*(double)unit;
        Console.WriteLine($"Amount Charges @Rs. 1.50 per unit:{a}");
       }
       else if(unit>=400 && unit<600)
       {
        double a=1.80*(double)unit;
        Console.WriteLine($"Amount Charges @Rs. 1.80 per unit: {a}");
        double amt=unit*15/100*1.80;
        Console.WriteLine($"Surcharge Amount : {amt}");
        double b= a+amt;
        Console.WriteLine($"Net Amount Paid By the Customer: {b}"); 
       }
       else if(unit>=600)
       {
        double a=2.00*(double)unit;
        Console.WriteLine($"Amount Charges @Rs. 2.00 per unit: {a}");
        double amt=unit*15/100*2.00;
        Console.WriteLine($"Surcharge Amount : {amt}");
         double b= a+amt;
         Console.WriteLine($"Net Amount Paid By the Customer: {b}"); 
       }
       else
       {
         Console.WriteLine("Amount Charges @Rs.100 for per unit");
       }

      
       
    }
}