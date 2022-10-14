using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridQuestion1
{
    public class Marksheet:TheoryExamMark,ICalculate
    {
        private static int s_marksheetNumber=1000;

        public string MarkSheetNumber { get; set; }

        public DateTime DateOfIssue { get; set; }

        public int Total { get; set; }
        
        public double Percentage { get; set; }

        public int ProjectMark { get; set; }
        
        


        public Marksheet(string name, string fatherName, long phone, DateTime dob,Gender gender,int sem1, int sem2, int sem3, int sem4, DateTime dateOfIssue,int total, int percentage):base(name, fatherName, phone, dob,gender,sem1, sem2, sem3, sem4)
        {
            s_marksheetNumber++;
            MarkSheetNumber="MSNO"+s_marksheetNumber;
            DateOfIssue=dateOfIssue;
            Total=total;
            Percentage=percentage;
        }

        // public void ShowUGMarkSheet()
        // {
        //     ShowSemMark();
        //     Console.WriteLine("Mark Sheet Number: "+MarkSheetNumber+"\n"+"Date Of Issues: "+DateOfIssue+"\n"+"Total: "+Total+"\n"+"Percentage: "+Percentage);
        // }

        public void CalculateUG()
        {
            Total=Sem1+Sem2+Sem3+Sem4+ProjectMark;
            Percentage=(double)Total/500*100;
            ShowSemMark();
            Console.WriteLine("Mark Sheet Number: "+MarkSheetNumber+"\n"+"Date Of Issues: "+DateOfIssue.ToShortDateString()+"\n"+"Total: "+Total+"\n"+"Percentage: "+Percentage);
        }

    }
}