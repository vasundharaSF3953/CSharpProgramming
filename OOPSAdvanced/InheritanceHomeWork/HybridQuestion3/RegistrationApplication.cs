using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridQuestion3
{
    public class RegistrationApplication:UgInfo
    {
        private static int s_registerNumber=10000;

        public string RegisterNumber { get; set; }
        
        public int Experience { get; set; }
        
        public string Interest { get; set; }


        public RegistrationApplication(string name, Gender gender, DateTime dob, long phone, long mobile, string fatherName, string motherName, string permanentAddress,string degree, string branch, int sem1, int sem2, int sem3, int sem4,int experience, string interest):base( name, gender,  dob, phone,  mobile, fatherName,  motherName, permanentAddress, degree,  branch,  sem1, sem2, sem3,  sem4)
        {
            s_registerNumber++;
            RegisterNumber="RNO"+s_registerNumber;
            Experience=experience;
            Interest=interest;
        }

        public void ShowRegistrationDetails()
        {
            ShowUgMarkDetails();
            CheckEligibility();
            Console.WriteLine("RegistrationNumber: "+RegisterNumber+"\n"+"Experience: "+Experience+"\n"+"Area of Interest: "+Interest);
        }
        
        
    }
}