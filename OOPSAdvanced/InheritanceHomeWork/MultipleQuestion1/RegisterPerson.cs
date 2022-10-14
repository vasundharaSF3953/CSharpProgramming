using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleQuestion1
{
    public class RegisterPerson:PersonalInfo,IFamilyInfo, iShowData
    {
        private static int s_registrationNumber=1000;


        public string RegistrationNumber { get; set; }

        public DateTime Date1 { get; set; }


        public string FatherName { get; set; }
        
        public string MotherName { get; set; }

        public string Address { get; set; }

        public int Siblings { get; set; }


        


        public RegisterPerson(string personalId,string name, Gender gender, DateTime dob, long phone, long mobile, MaritalDetails maritalDetails,DateTime date1):base(personalId, name, gender, dob, phone, mobile,maritalDetails)
        {
             s_registrationNumber++;
             RegistrationNumber="RNO"+s_registrationNumber;
             Date1=date1;
        }
        

        public void ShowRegistrationInfo()
        {
            Console.WriteLine("RegistrationNumber: "+RegistrationNumber+"\n"+"Date: "+Date1.ToShortDateString());
        }
        public void ShowFamilyInfo(string fatherName, string motherName, string address, int siblings)
        {
            ShowInfo();
            Console.WriteLine("Father Name: "+fatherName+"\n"+"Mother Name: "+motherName+"\n"+"Address: "+address+"\n"+"Siblings: "+siblings);
        }
        
        
    }
}