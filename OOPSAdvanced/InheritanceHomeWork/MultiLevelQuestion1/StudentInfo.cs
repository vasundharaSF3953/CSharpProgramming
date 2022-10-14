using System;


namespace MultiLevelQuestion1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_registerNumber=100;   //Field Creation 

        public string RegisterNumber { get; set; }  //Property Creation

        public string Standard { get; set; }


        public string Branch{ get; set; }

        public int AcadamicYear { get; set; }

        public StudentInfo(string personalId, string name, string fatherName, long phoneNumber, string mailId, DateTime dob, Gender gender,string standard, string branch, int acadamicYear):base(personalId, name, fatherName, phoneNumber, mailId, dob, gender)
        {
            s_registerNumber++;
            RegisterNumber="RNO"+s_registerNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicYear;
        }

         public StudentInfo(string registerNumber,string personalId, string name, string fatherName, long phoneNumber, string mailId, DateTime dob, Gender gender,string standard, string branch, int acadamicYear):base(personalId, name, fatherName, phoneNumber, mailId, dob, gender)
        {
            
            RegisterNumber=registerNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicYear;
        }
        
        public void ShowStudentInfo()
        {
            Console.WriteLine("Registration Number:"+RegisterNumber);
            ShowDetails();
            Console.WriteLine("Standard: "+Standard+"\n"+"Branch :"+Branch+"\n"+"AcadamicYear:"+AcadamicYear);
        }
        
        
        
        
        
        
    }
}