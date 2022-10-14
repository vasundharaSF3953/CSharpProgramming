using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApplication
{
    public class PersonalDetails
    {
            public string Name { get; set; }     //Property Creation
            
            public string FatherName { get; set; }
            
            public string Gender { get; set; }
            
            public long Mobile { get; set; }
            
            public DateTime DOB { get; set; }
            
            public string MailID { get; set; }
            
            public string Location { get; set; }
            

            //Parameterized constructor
            public PersonalDetails(string name, string fatherName, string gender, long mobile,DateTime dob, string mailId, string location)
            {
               Name=name;
               FatherName=fatherName;
               Gender=gender;
               Mobile=mobile;
               DOB=dob;
               MailID=mailId;
               Location=location;
            }

            public PersonalDetails(string data)
            {
                string[] values=data.Split(',');
                Name=values[2];
                FatherName=values[3];
                Gender=values[4];
                Mobile=long.Parse(values[5]);
                DOB=DateTime.ParseExact(values[6],"dd/MM/yyyy",null);
                MailID=values[7];
                Location=values[8];
            }


            public void ShowPersonalDetails()
            {
                Console.WriteLine("Name: "+Name+"\n"+"Father Name: "+FatherName+"\n"+"Gender: "+Gender+"\n"+"Mobile: "+Mobile+"\n"+"DOB: "+DOB.ToShortDateString()+"\n"+"MailId"+MailID+"\n"+"Location: "+Location);
            }
    }
}