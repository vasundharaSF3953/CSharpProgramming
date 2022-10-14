using System;
namespace MethodsPractise;
class Program
{
    public static void Main(string[] args)
    {
        //Method with argument and with return type

        int number1=20, number2=5;
        int sum=Addition(number1,number2);
        Console.WriteLine("The Sum is:"+sum);
       

        int Addition(int value1,int value2)
        {
            int sum;
            sum=value1+value2;
            return sum;
        }

        //Method withe argument withour return type

        
        Subtraction(number1,number2);

        void Subtraction(int value1,int value2)
        {
            int sub;
            sub=value1-value2;
            Console.WriteLine("The subtraction value is:"+sub);
        }

        //Method without argument with return type
        int product=Multiplication();
         Console.WriteLine("The multiplication value is:"+product);

        int Multiplication()
        {
            int data1=3, data2=4;
            int multiply=data1*data2;
            return multiply;
        }

        //Method without argument without return type

        

    }
}
