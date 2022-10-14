using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your basic salary:");
        int salary=int.Parse(Console.ReadLine());

        int basicSalary=salary+10/100+10/100;
        Console.WriteLine(basicSalary);
        int annualSalary=basicSalary*12-5/100;
        Console.WriteLine("The annual salary of the person is:"+annualSalary);
        
    }
}
