using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employment
{
    public enum Gender{Default,Male, Female}
    public class PersonalDetails
    {

        static List<PersonalDetails> PersonalDetailsList=new List<PersonalDetails>();
        private static int s_aadharNumber=1000;   //FieldCreation

        public string AadharId { get; set; }    //Property Creation

        public string Name { get; set; }

        public string FatherName { get; set; }

        public Gender Gender { get; set; }
        
         public long PhoneNumber { get; set; }
        
        

        //Parameterized Constructor creation
        public PersonalDetails(string name,string fatherName, Gender gender, long phoneNumber)
        {
            s_aadharNumber++;
            AadharId="xxxx"+s_aadharNumber;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phoneNumber;
        }


        public static void ShowDetails()
        {
            foreach(PersonalDetails details in PersonalDetailsList)
            {
                Console.WriteLine(details.AadharId+"\t"+details.Name+"\t"+details.FatherName+"\t"+details.PhoneNumber+"\t"+details.Gender);
            }
        }
      
       
        
        
        
        
        
    }
}