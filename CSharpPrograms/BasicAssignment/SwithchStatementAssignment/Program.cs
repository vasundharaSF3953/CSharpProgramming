using System;
namespace SwithStatementAssignment;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter First Number:");
        int num1=int.Parse(Console.ReadLine());
 
        Console.WriteLine("Enter Second Number:");
        int num2=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter any of the operator + - * / %");
        char choice=char.Parse(Console.ReadLine());

        switch(choice)
        {
            case '+':
            {
                int  add=num1+num2;
                Console.WriteLine($"{num1}+{num2}= {add}");
                break;
            }

            case '-':
            {
                int  sub=num1-num2;
                Console.WriteLine($"{num1}-{num2}= {sub}");
                break;
            }

             case '*':
            {
                int  multiply=num1*num2;
                Console.WriteLine($"{num1}*{num2}= {multiply}");
                break;
            }

            case '/':
            {
                int  divide=num1/num2;
                Console.WriteLine($"{num1}/{num2}= {divide}");
                break;
            }
            case '%':
            {
                int  modulo=num1%num2;
                Console.WriteLine($"{num1}%{num2}= {modulo}");
                break;
            }
            default:
            {
                Console.WriteLine("You have entered different operator");
                break;
            }

        }




    }
}