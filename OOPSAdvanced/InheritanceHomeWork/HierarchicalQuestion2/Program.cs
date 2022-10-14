using System;
namespace HierarchicalQuestion2;

class Program
{
    public static void Main(string[] args)
    {
        PermanentEmployee employee1=new PermanentEmployee(25000,4,"Permanent",0.2,0.18,0.1);
        employee1.PermanentEmployeeDetails();

        TemporaryEmployee  employee2=new TemporaryEmployee(30000,4,"Permanent",0.25,0.13,0.1);
        employee2.ShowSalaryDetails();
    }
}
