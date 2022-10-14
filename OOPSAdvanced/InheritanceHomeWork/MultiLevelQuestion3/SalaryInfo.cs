using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelQuestion3
{
    public class SalaryInfo:PersonalInfo
    {
        public int SalaryOfMonth { get; set; }

        public int Month { get; set; }

        public SalaryInfo(string personalId,string name, string fatherName, Gender gender, long mobile, DateTime dateTime,int salary, int month):base(personalId,name, fatherName, gender, mobile, dateTime)
        {
            SalaryOfMonth=salary;
            Month=month;

        }

        public void ShowSalaryDetails()
        {
            ShowPersonalDetails();
            Console.WriteLine("SalaryOfMonth: "+SalaryOfMonth+"\n"+"Month: "+Month);
        }
        
        
        
        
    }
}