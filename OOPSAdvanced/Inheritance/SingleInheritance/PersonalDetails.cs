using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public enum Gender{Default,Male, Female}
    public class PersonalDetails
    {

       
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

         public PersonalDetails(string aid,string name,string fatherName, Gender gender, long phoneNumber)
        {
            
            AadharId=aid;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phoneNumber;
        }


        public void ShowDetails()
        {
            
                System.Console.WriteLine("AadharId:"+AadharId);
                System.Console.WriteLine("Name:"+Name);
                System.Console.WriteLine("Gender:"+Gender);
                System.Console.WriteLine("PhoneNumber:"+PhoneNumber);
           
        
        }
      
       
        
        
        
        
        
    }
}