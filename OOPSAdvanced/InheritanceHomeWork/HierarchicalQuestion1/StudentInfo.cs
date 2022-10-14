using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalQuestion1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_studentId=1000;

        public string StudentId { get; set; }

        public string Degree { get; set; }

        public string Departments { get; set; }

        public int Semester { get; set; }


        public StudentInfo(string personalId,string name, string fatherName, DateTime dob, long phoneNumber,Gender gender, string mail,string degree, string department, int semester):base(personalId,name, fatherName, dob, phoneNumber,gender, mail)
        {
            s_studentId++;
            StudentId="SID"+s_studentId;
            Degree=degree;
            Departments=department;
            Semester=semester;


        }

        public void ShowStudentInfo()
        {
            Console.WriteLine("Degree:"+Degree+"\n"+"Departments:"+Departments+"\n"+"Semester:"+Semester);
            ShowPersonalDetails();
        }
        
        
        
        
        
        
        
        
    }
}