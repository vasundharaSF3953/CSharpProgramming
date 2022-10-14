using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridQuestion3
{

    public enum Gender{Female,Male,TransGender}
    public class PersonalInfo:IFamilyInfo
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }


        public DateTime DOB { get; set; }
        
         
        public long Phone { get; set; }
        
        
        public long Mobile { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public string PermanantAddress { get; set; }
        
        
        public PersonalInfo(string name, Gender gender, DateTime dob, long phone, long mobile, string fatherName, string motherName, string permanentAddress)
        {
            Name=name;
            Gender=gender;
            DOB= dob;
            Phone=phone;
            Mobile=mobile;
            FatherName=fatherName;
            MotherName=motherName;
            PermanantAddress=permanentAddress;
        }

        public void ShowPersonalDetails()
        {
            Console.WriteLine("Name: "+Name+"\n"+"Gender: "+Gender+"\n"+"DOB: "+DOB+"\n"+"Phone: "+Phone+"\n"+"Mobile: "+Mobile+"\n"+"Father Name: "+FatherName+"\n"+"Mother Name: "+MotherName+"\n"+"Permanant Address: "+PermanantAddress);
        }
        
        
        
        
        
        
        
    }
}