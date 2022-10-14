using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleQuestion1
{
    public class StudentInfo:PersonalInfo      //Inherited
    {
        private static int s_registerNumber=1000;   //Field creation

        public string RegisterNumber { get; set; }   //Property Creation

        public string Standard { get; set; }

        public string Branch { get; set; }

        public int AcadamicYear { get; set; }
        
        public StudentInfo(string personId,string name,string fatherName, long phoneNumber, string mailId, DateTime dob, Gender gender,string standard, string branch,int acadmicYear):base(personId,name,fatherName,phoneNumber,mailId,dob,gender)
        {
            s_registerNumber++;
            RegisterNumber="RNO"+s_registerNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadmicYear;

        }

        public void UpdateInfo()
        {
            Console.WriteLine("Register Number: "+RegisterNumber);
            ShowInfo();   //Inherit method from base class
            Console.WriteLine("Standard:"+Standard);
            Console.WriteLine("Branch:"+Branch);
            Console.WriteLine("AcadamicYear:"+AcadamicYear);
        }
    
        
        
        
        
        
        
    }
}