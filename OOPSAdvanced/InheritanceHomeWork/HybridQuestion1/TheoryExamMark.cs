using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridQuestion1
{
    public class TheoryExamMark:PersonalInfo
    {
        
        public int Sem1 { get; set; }

        public int Sem2 { get; set; }

        public int Sem3 { get; set; }

        public int Sem4 { get; set; }

    
        
        
        public TheoryExamMark(string name, string fatherName, long phone, DateTime dob,Gender gender,int sem1, int sem2, int sem3, int sem4):base(name, fatherName, phone, dob, gender)
        {
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
         
        }

        public void ShowSemMark()
        {
            ShowPersonlaInfo();
            Console.WriteLine("Sem1: "+Sem1+"\n"+"Sem2: "+Sem2+"\n"+"Sem3: "+Sem3+"\n"+"Sem4: "+Sem4);
        }

        
    }
}