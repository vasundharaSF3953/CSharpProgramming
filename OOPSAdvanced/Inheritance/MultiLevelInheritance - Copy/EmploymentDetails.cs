using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class EmploymentDetails:StudentDetails
    {
        private static int s_employmentId=1000;

        public string EmploymentId { get; set; }

        public DateTime DateOfEmployment { get; set; }
        
        public EmploymentDetails(string studentId,string aid,string name,string fatherName, Gender gender, long phoneNumber,Department department):base(studentId,aid, name,fatherName, gender,  phoneNumber,department)
        {
            s_employmentId++;
            EmploymentId="EID"+s_employmentId;
            DateOfEmployment=DateTime.Now;

        }
        
        public void ShowEmploymentDetail()
        {
            System.Console.WriteLine("EmploymentId:"+EmploymentId);
            ShowStudentDetails();
            System.Console.WriteLine("Registration date:"+DateOfEmployment.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Last Date of employement:"+DateOfEmployment.AddDays(365).ToString("dd/MM/yyyy"));
        }
    }
}