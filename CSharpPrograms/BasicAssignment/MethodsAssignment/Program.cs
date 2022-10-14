using System;
namespace MethodsAssignment;
class Program
{
    public static void Main(string[] args)
    {
        string option;
        int value1, value2;
        do{

        Console.WriteLine("Select any one of the option 1.Addition 2.Subtraction 3.Multiplication 4.Division");
        int choice=int.Parse(Console.ReadLine());

         Console.Write("Enter first number:");
          value1=int.Parse(Console.ReadLine());

         Console.Write("Enter second number:");
         value2=int.Parse(Console.ReadLine());
         

        switch(choice)
        {
           case 1:
           {
            int add=Addition(value1,value2);
            Console.WriteLine("The addition of two number is:"+add);
            break;
           }
           case 2:
           {
            Subtraction(value1,value2);
            
            break;
           }
           case 3:
           {
            int product=Multiplication();
            Console.WriteLine("The product of two number is:"+product);
            break;
           }
           case 4:
           {
            Division();
            break;
           }
           default:
           {
            Console.WriteLine("You have enter the wrong choice");
            break;
           }
        }

       
         Console.Write("Do you want to repeat the process:");
         option=Console.ReadLine().ToLower();

        }while(option=="yes"); 


         //with Argument with return type
        int Addition(int data1,int data2)
        {
            int sum;
            sum=data1+data2;
            return sum;
        }

         
         //with argument without return type
           void Subtraction(int data1,int data2)
        {
            int subtract;
            subtract=data1-data2;
            Console.WriteLine("The subtraction of two number is: "+subtract);
        }

        //without argument with return type
           int Multiplication()
        {
            int multiply;
            multiply=value1*value2;
            return multiply;
        }


        //without argument without return type
          void Division()
        {
            int divide;
            divide=value1/value2;
            Console.WriteLine("The division of two number is: "+divide);
        }

    }
    
    
}