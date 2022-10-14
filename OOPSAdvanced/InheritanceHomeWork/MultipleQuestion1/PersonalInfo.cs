using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleQuestion1
{
    public enum Gender{Female, Male, TransGender}

    public enum MaritalDetails{Married, Single}
    public class PersonalInfo:iShowData
    {
        private static int s_personalId=1;

        public string PersonalId { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public long Phone { get; set; }

        public long Mobile { get; set; }

        public MaritalDetails MaritalDetails{ get; set; }

        public PersonalInfo(string name, Gender gender, DateTime dob, long phone, long mobile, MaritalDetails maritalDetails)
        {
            s_personalId++;
            PersonalId="PID"+s_personalId;
            Name=name;
            Gender=gender;
            DateOfBirth=dob;
            Phone=phone;
            Mobile=mobile;
            MaritalDetails=maritalDetails;
        }


         public PersonalInfo(string personalId,string name, Gender gender, DateTime dob, long phone, long mobile, MaritalDetails maritalDetails)
        {
            
            PersonalId=personalId;
            Name=name;
            Gender=gender;
            DateOfBirth=dob;
            Phone=phone;
            Mobile=mobile;
            MaritalDetails=maritalDetails;
        }
        public void ShowInfo()
        {
            Console.WriteLine("PersonalID: "+PersonalId+"Name: "+Name+"\n"+"Gender: "+Gender+"\n"+"DOB:"+DateOfBirth.ToShortDateString()+"\n"+"Phone: "+Phone+"\n"+"Mobile: "+Mobile+"\n"+"Marital Status: "+MaritalDetails);
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}