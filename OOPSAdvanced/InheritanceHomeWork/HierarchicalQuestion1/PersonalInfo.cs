using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Base Class
namespace HierarchicalQuestion1
{

    public enum Gender{Default, Female, Mail}
    public class PersonalInfo
    {
        private static int s_PresonalId=1000;

        public string PersonalId { get; set; }
        
        public string Name { get; set; }

        public string FatherName { get; set; }

        public DateTime DOB { get; set; }

        public long Phone { get; set; }

        public Gender Gender { get; set; }

        public string Mail { get; set; }
        
        
        
        public PersonalInfo(string name, string fatherName, DateTime dob, long phoneNumber,Gender gender, string mail)
        {
            s_PresonalId++;
            PersonalId="PID"+s_PresonalId;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Phone=phoneNumber;
            Gender=gender;
            Mail=mail;

        }


         public PersonalInfo(string personalId,string name, string fatherName, DateTime dob, long phoneNumber,Gender gender, string mail)
        {
            
            PersonalId=personalId;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Phone=phoneNumber;
            Gender=gender;
            Mail=mail;

        }
        
        public void ShowPersonalDetails()
        {
            Console.WriteLine("Name:"+Name+"\n"+"FatherName:"+FatherName+"\n"+"DOB:"+DOB+"\n"+"Phone:"+Phone+"\n"+"Gender:"+Gender+"\n"+"Mail:"+Mail);
        }
        
        
        
        
        
        
    }
}