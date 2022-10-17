using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your salary:");
        int salary=int.Parse(Console.ReadLine());

        if(salary<=10000)
        {
            int monthlySalary=salary+20/100+80/100;
            int yearSalary=12*monthlySalary-6/100-1/100;
            Console.WriteLine("Annual salary "+yearSalary);
        }
        else if(salary>10000 && salary<=20000)
        {
            int monthlySalary=salary+20/100+80/100;
            int yearSalary=12*monthlySalary-6/100-1/100;
            Console.WriteLine("Annual salary "+yearSalary);
        }
        else
        {
            int monthlySalary=salary+20/100+80/100;
            int yearSalary=12*monthlySalary-6/100-1/100;
            Console.WriteLine("Annual salary "+yearSalary);

        }
        
    }
}
