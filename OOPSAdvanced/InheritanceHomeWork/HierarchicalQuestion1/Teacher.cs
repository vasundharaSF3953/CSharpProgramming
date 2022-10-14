using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalQuestion1
{
    public class Teacher: PersonalInfo
    {
        private static int s_teacherId=1000;

        public string TeacherId { get; set; }

        public string Department { get; set; }

        public string SubjectTeaching { get; set; }

        public string Qualification { get; set; }

        public int YearOfExperience { get; set; }

        public DateTime DateOfJoining { get; set; }


        public Teacher(string personalId,string name, string fatherName, DateTime dob, long phoneNumber,Gender gender, string mail,string department, string subjectTeaching, string qualification, int yearOfExperience, DateTime dateOfJoining):base(personalId,name, fatherName, dob, phoneNumber,gender, mail)
        {
           s_teacherId++;
           TeacherId="TID"+s_teacherId;
           Department=department; 
           SubjectTeaching=subjectTeaching;
           Qualification=qualification;
           YearOfExperience=yearOfExperience;
           DateOfJoining=dateOfJoining;
        }
        
        public void showTeacherDetails()
        {
            Console.WriteLine("Department:"+Department+"\n"+"SubjectTeaching:"+SubjectTeaching+"\n"+"Qualification:"+Qualification+"\n"+"YearOfExperience:"+YearOfExperience+"\n"+"DateOfJoining:"+DateOfJoining);
            ShowPersonalDetails();
        }
        
        
        
        
        
        
        
        
        
        
    }
}