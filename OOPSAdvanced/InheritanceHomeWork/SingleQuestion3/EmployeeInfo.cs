using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleQuestion3
{

    public enum Gender{Female, Male, TransGender}
    public class EmployeeInfo:SalaryInfo
    {
        private static int s_employeeId=1000;

        public string EmployeeId { get; set; }
        
        public string Name { get; set; }
        
        public string FatherName { get; set; }
        
        public Gender Gender { get; set; }

        public long Mobile { get; set; }
        
        public DateTime DOB { get; set; }
        
        public string Branch { get; set; }
        
        List<Attendance> attendanceList=new List<Attendance>();
        
        public EmployeeInfo(int salaryOfMonth, int month,string name, string fatherName, Gender gender,long mobile, DateTime dob,string branch):base(salaryOfMonth, month)
        {
            s_employeeId++;
            EmployeeId="EID"+s_employeeId;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            Branch=branch;
        }

        public void UpdateDetails()
        {

        }

        public void ShowDetails()
        {
           System.Console.WriteLine("EmployeeId: "+EmployeeId+"\n"+"Name: "+Name+"\n"+"Father Name: "+FatherName+"\n"+"Gender: "+Gender+"\n"+"Mobile Number: "+Mobile+"\n"+"Date Of Birth: "+DOB.ToShortDateString()+"\n"+"Branch: "+Branch);
           SalaryCalculation();
           DisplaySalary();
        }
    }
}