using System;
namespace IfStatementAssignment;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Mark:");
        int mark=int.Parse(Console.ReadLine());
        

        if(mark>80 && mark<=100)
        {
          Console.WriteLine("Grade A");
        }
        else if(mark>60 && mark<=80 )
        {
          Console.WriteLine("Grade B");
        }

        else if(mark>35 && mark<=60)
        {
            Console.WriteLine("Grade C");
        }
        else if(mark>1 && mark<=35)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}