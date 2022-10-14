using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiPathQuestion1
{
    public class PgCouncelling:IHSCInfo,IUgInfo
    {
        private static int s_applicationId=1000;

        private static int s_marksheetNumber=1000;

        public string UGMarkSheetNumber { get; set; }

        public string ApplicationId { get; set; }
        
        public DateTime DateOfApplication { get; set; }
        
        public int Fees { get; set; }

        public string MarkSheetNumber { get; set; }
        
        public int Physics { get; set; }
        
        public int Chemistry { get; set; }
        
        public int Maths { get; set; }
        
        public int Total { get; set; }
        
        public double Percentage { get; set; }

        public long AdharNumber { get; set; }
        
        public string Name { get; set; }
        

        public string FatherName { get; set; }
        
        public long Phone { get; set; }
        
        public DateTime DOB { get; set; }
        
        public Gender Gender{ get; set; }

        
        public int Sem1 { get; set; }
        
        public int Sem2 { get; set; }
        
        public int Sem3 { get; set; }
        
        public int Sem4 { get; set; }
        
        public int TotalValue { get; set; }
        
        public double PercentageData { get; set; }

        
        public PgCouncelling(long aadharNumber,string name,string fatherName,long phone, DateTime dob, Gender gender, int physics, int chemistry, int maths, string hscMarksheetNumber, int sem1, int sem2, int sem3, int sem4, string ugMarkSheetNumber,DateTime dateOfApplication, int fees)
        {
            s_applicationId++;
            ApplicationId="AID"+s_applicationId;
            AdharNumber=aadharNumber;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            Gender=gender;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            MarkSheetNumber=hscMarksheetNumber;
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=Sem4;
            UGMarkSheetNumber=ugMarkSheetNumber;
            DateOfApplication=dateOfApplication;
            Fees=fees;
        } 


        public void ShowHscMarksheet()
        {
           Console.WriteLine("HSCMarkSheetNumber: "+MarkSheetNumber+"\n"+"Adhar Number: "+AdharNumber+"\n"+"Name: "+Name+"\n"+"FatherName: "+FatherName+"\n"+"Phone: "+Phone+"\n"+"DOB: "+DOB+"\n"+"Gender: "+Gender+"\n"+"Physics: "+Physics+"\n"+"Chemistry: "+Chemistry+"\n"+"Maths: "+Maths);
        }
        public void ShowCouncellingDetails()
        {
            Console.WriteLine("Application Id: "+ApplicationId+"\n"+"Date of Application: "+DateOfApplication.ToShortDateString()+"\n"+"Fees: "+Fees);
        } 

        public void CalculateHSC()
        {
            Total=Physics+Chemistry+Maths;
            Console.WriteLine("Total: "+Total);
            Percentage=(double)Total/300*100;
            Percentage=Math.Round(Percentage,2);
            Console.WriteLine("Percentage: "+Percentage);

        }

        public void ShowUgMarkSheet()
        {
            Console.WriteLine("UGMarkSheetNumber: "+UGMarkSheetNumber+"\n"+"Adhar Number: "+AdharNumber+"\n"+"Name: "+Name+"\n"+"FatherName: "+FatherName+"\n"+"Phone: "+Phone+"\n"+"DOB: "+DOB+"\n"+"Gender: "+Gender+"\n"+"Sem1: "+Sem1+"\n"+"Sem2: "+Sem2+"\n"+"Sem3: "+Sem3+"\n"+"Sem4: "+Sem4);
        

        }

        public void CalculateUg()
        {
            TotalValue=Sem1+Sem2+Sem3+Sem4;
            Console.WriteLine("Total: "+TotalValue);
            Percentage=(double)Total/400*100;
            Console.WriteLine("Percentage: "+Percentage);

        }

        public void PayFees()
        {
            Console.WriteLine("pay the amount");
            Fees=int.Parse(Console.ReadLine());
            
        }

    }
}