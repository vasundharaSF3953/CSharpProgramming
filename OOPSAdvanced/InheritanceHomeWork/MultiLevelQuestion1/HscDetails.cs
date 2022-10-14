using System;


namespace MultiLevelQuestion1
{
    public class HscDetails:StudentInfo
    {
        private static int s_hscMarkNumber=1000;  //Field Creation

        public string HscMarkDetails { get; set; }   //Property Creation

        public int Physics { get; set; }

        public int Chemistry { get; set; }

        public int Maths { get; set; }

        public int Total { get; set; }

        public double Percentage { get; set; }
        
        
        //Constructor creation

        public HscDetails(string registerNumber,string personalId, string name, string fatherName, long phoneNumber, string mailId, DateTime dob, Gender gender,string standard, string branch, int acadamicYear,int physics, int chemistry, int maths, int total, double percentage):base(registerNumber,personalId,name, fatherName, phoneNumber, mailId,dob, gender,standard, branch, acadamicYear)
        {
            s_hscMarkNumber++;
            HscMarkDetails="HSC"+s_hscMarkNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            Total=total;
            Percentage=percentage;

        }

        public void Calculate()
        {
            Total=Physics+Chemistry+Maths;
            Percentage=Total/300*100;
        }

        public void ShowMarksheet()
        {
           
            Console.WriteLine("Physics Mark: "+Physics+"\n"+"Chemistry Mark: "+Chemistry+"\n"+"Maths Mark: "+Maths+"\n"+"Total :"+Total+"\n"+"Percentage: "+Percentage);
        }
        
        
        
        
        
        
        
        
        
        
    }
}