using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public enum Department{Default, EEE, CSE,ECE}
    public class StudentDetails:PersonalDetails,iMarkDetails
    {
        private static int s_studentId=1000;

        public string StudentId { get; set; }

        public Department Department { get; set; }

        public string Year{ get; set; }

         public int Physics{ get; set; }   

        public int Chemistry{ get; set; }
  

        public int Maths{ get; set; }

        public int Total{ get; set; }

        public double Average{ get; set; }
        
        
        public StudentDetails(string aid,string name,string fatherName, Gender gender, long phoneNumber,Department department,string year) :base(aid, name, fatherName,  gender,  phoneNumber)
        {
            s_studentId++;
            StudentId="SID"+s_studentId;
            Department=department;
            Year=year;

        }

         public StudentDetails(string studentId,string aid,string name,string fatherName, Gender gender, long phoneNumber,Department department) :base(aid, name, fatherName,  gender,  phoneNumber)
        {
            StudentId=studentId;
            Department=department;
          

        }

        public void ShowStudentDetails()
        {
            System.Console.WriteLine("StudentID:"+StudentId);
            ShowDetails();
            System.Console.WriteLine("Department:"+Department);
            // System.Console.WriteLine("Year:"+Year);
        }
        
        public void GetMark(int physics, int chemistry,int maths)

        {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        public void Calculate()
        {
            Total=Physics+Chemistry+Maths;
            Average=(double)Total/3.0;
        }

        public void ShowMark()
        {
            System.Console.WriteLine("Physics:"+Physics+"Chemistry:"+Chemistry+"Maths:"+Maths);
            System.Console.WriteLine("Total:"+Total);
        }
        
    }
}