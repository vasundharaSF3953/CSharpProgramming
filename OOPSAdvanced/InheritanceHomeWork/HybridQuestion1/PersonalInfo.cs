using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridQuestion1
{
    public enum Gender{Female, Male, TransGender}
    public class PersonalInfo
    {
        private static int s_RegistrationNumber=1000;

        public string RegistrationNumber { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public long Phone { get; set; }

        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }


        public PersonalInfo(string name, string fatherName, long phone, DateTime dob,Gender gender)
        {
            s_RegistrationNumber++;
            RegistrationNumber="RNO"+s_RegistrationNumber;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            Gender=gender;

        }

        public void ShowPersonlaInfo()
        {
             Console.WriteLine("Registration Number: "+RegistrationNumber+"\n"+"Name: "+Name+"\n"+"Father Name: "+FatherName+"\n"+"Phone: "+Phone+"\n"+"Date Of Birth: "+DOB.ToShortDateString()+"\n"+"Gender: "+Gender);
        }



        
        
        
        
        
        
        
        
        
        
    }
}