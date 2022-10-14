using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleQuestion2
{

    public enum Gender{Default, Female, Male}
    public class PersonalInfo
    {
        private static int s_personId=100;   //Field Creation

        public string PersonId { get; set; }  //Property Creation

        public string Name { get; set; }
        

        public string FatherName { get; set; }

        public long Phone { get; set; }

        public string Mail { get; set; }

        public DateTime DOB { get; set; }


        public Gender Gender { get; set; }
        
        

        //constructor creation
        public PersonalInfo(string name, string fatherName,long phoneNumber, string mailId,DateTime dob,Gender gender)
        {
            s_personId++;
            PersonId="PID"+s_personId;
            Name=name;
            FatherName=fatherName;
            Phone=phoneNumber;
            Mail=mailId;
            DOB=dob;
            Gender=gender;
        }


         public PersonalInfo(string personId, string name, string fatherName,long phoneNumber, string mailId,DateTime dob,Gender gender)
        {
            
            PersonId=personId;
            Name=name;
            FatherName=fatherName;
            Phone=phoneNumber;
            Mail=mailId;
            DOB=dob;
            Gender=gender;
        }


        //ShowDetails Method
        public void showDetails()
        {
            Console.WriteLine("PersonId: "+PersonId+"\n"+"Name: "+Name+"\n"+"Father Name: "+FatherName+"\n"+"Phone Number: "+Phone+"\n"+"Mail: "+Mail+"\n"+"Date Of Birth: "+DOB+"\n"+"Gender: "+Gender);
        }
        
        
        
        
        
        
        
        
        
        
        
        
    }
}