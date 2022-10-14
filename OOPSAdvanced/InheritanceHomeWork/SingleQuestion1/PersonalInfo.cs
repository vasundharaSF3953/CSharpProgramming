using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Base Class
namespace SingleQuestion1
{

    public enum Gender{Default,Female, Male}
    public class PersonalInfo
    {
        private static int s_PersonId=100;    //Field Creation

        public string PersonId { get; set; }  //Property Creation

        public string Name { get; set; }

        public string FatherName { get; set; }

        public long PhoneNumber { get; set; }

        public string MailId { get; set; }

        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }
        
        
         //Parameter Construcor creation
         public PersonalInfo(string name,string fatherName, long phoneNumber, string mailId, DateTime dob, Gender gender)
         {
            s_PersonId++;
            PersonId="PID"+s_PersonId;
            Name=name;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            MailId=mailId;
            DOB=dob;
            Gender=gender;

         }



         public PersonalInfo(string personId,string name,string fatherName, long phoneNumber, string mailId, DateTime dob, Gender gender)
         {
            
            PersonId=PersonId;
            Name=name;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            MailId=mailId;
            DOB=dob;
            Gender=gender;

         }



         //ShowMethod creation
         public void ShowInfo()
         {
            Console.WriteLine("Name: "+Name+"\n"+"FatherName: "+FatherName+"\n"+"PhoneNumber: "+PhoneNumber+"\n"+"MailId: "+MailId+"\n"+"DateOfBirth: "+DOB.ToString("dd/MM/yyyy")+"\n"+"Gender: "+Gender);
         }

        
        
        
        
        
        
        
        
        
        
        
        
    }
}