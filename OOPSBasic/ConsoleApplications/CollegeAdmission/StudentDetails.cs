using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class StudentDetails
    {
        //private string _name; //Field declaration

        // public string Name { get{return _name;} set{_name=value;} }

        public string Name { get; set; } //AutoProperty

        public string FatherName { get; set; }

        public DateTime DOB { get; set; }

        public string Gender { get; set; }

        public long Phone { get; set; }

        public string Mail { get; set; }

        public int Physics { get; set; }

        public int Chemistry { get; set; }

        public int Maths { get; set; }
        
        public StudentDetails()    //Default Constructor
        {
            Name="your name";
            FatherName="your father name";    
            Mail="abc@gmail.com";
            
        }

        public StudentDetails(string name,string fatherName, DateTime  dob, long phone, string gender, string mail, int physicsMark, int chemistryMark, int mathsMark)    //Parameter Constructor 
        {
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Mail=mail;
            Phone=phone;
            Physics=physicsMark;
            Chemistry=chemistryMark;
            Maths=mathsMark;

        }
        
        
        
        


        
        
        
        
        
        
        
        
        
        
    }
}