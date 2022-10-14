using System;
namespace SingleQuestion3;
class Program
{
    public static void Main(string[] args)
    {
         EmployeeInfo employee1=new EmployeeInfo(0,2,"Vasundhara","Gnanam",Gender.Female,1234567890,DateTime.Now,"Development");
         employee1.ShowDetails();

         

    //    Attendance attendance1=new Attendance(new DateTime(2022,10,05),8);

    //    SalaryInfo salary1=new SalaryInfo(500,1);
    //    salary1.SalaryCalculation();
    //    salary1.DisplaySalary();
    }
   

}
