using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridQuestion3
{
    public class UgInfo:PersonalInfo
    {
        private static int s_ugMarkSheetNumber=100;

        public string UgMarkSheetNumber { get; set; }
        
        public string Degree{ get; set; }
        
        public string Branch { get; set; }
        
        public int Sem1 { get; set; }


        public int Sem2 { get; set; }
        
        public int Sem3 { get; set; }


        public int Sem4 { get; set; }

      
        public UgInfo(string name, Gender gender, DateTime dob, long phone, long mobile, string fatherName, string motherName, string permanentAddress,string degree, string branch, int sem1, int sem2, int sem3, int sem4):base(name,gender, dob, phone, mobile, fatherName, motherName, permanentAddress)
        {
             s_ugMarkSheetNumber=1000;
             UgMarkSheetNumber="UGMS"+s_ugMarkSheetNumber;
             Degree=degree;
             Branch=branch;
             Sem1=sem1;
             Sem2=sem2;
             Sem3=sem3;
             Sem4=sem4;
        }
        
        public void ShowUgMarkDetails()
        {
            ShowPersonalDetails();
            Console.WriteLine("Mark Sheet number: "+UgMarkSheetNumber+"\n"+"Degree: "+Degree+"\n"+"Branch: "+Branch+"\n"+"Sem1: "+Sem1+"\n"+"Sem2: "+Sem2+"\n"+"Sem3: "+Sem3+"\n"+"Sem4: "+Sem4);
        }

        public void CheckEligibility()
        {
            int Total=Sem1+Sem2+Sem3+Sem4;
            double Percentage=(double)Total/400*100;
            if(Percentage>75)
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
            
        }
        
        
        
        
        
        
        
    }
}