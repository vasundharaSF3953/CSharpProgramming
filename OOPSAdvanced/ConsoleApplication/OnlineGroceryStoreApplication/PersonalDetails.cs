using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{

    public enum Gender{Default, Female, Male, TransGender}
    public class PersonalDetails
    {
        public string Name { get; set; }
        
        public string FatherName { get; set; }
        
        public Gender Gender { get; set; }
         
        public long MobileNumber { get; set; }
        
        public DateTime DOB { get; set; }
        
        public string MailId { get; set; }
        
        public PersonalDetails(string name, string fatherName, Gender gender, long mobileNumber, DateTime dob, string mailID)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNumber;
            DOB=dob;
            MailId=mailID;
        } 

        public PersonalDetails(string data)
        {
            string[] value=data.Split(',');
            Name=value[1];
            FatherName=value[2];
            Gender=Enum.Parse<Gender>(value[3]);
            MobileNumber=long.Parse(value[4]);
            DOB=DateTime.ParseExact(value[5],"dd/MM/yyyy",null);
            MailId=value[6];

        }

        public void ShowPersonalDetails()
        {
            Console.WriteLine("Name: "+Name+"\t"+"Father Name: "+FatherName+"\t"+"Gender: "+Gender+"\t"+"Mobile Number: "+MobileNumber+"\t"+"DOB: "+DOB.ToShortDateString()+"\t"+"MailId: "+MailId);
        }
        
    }
}