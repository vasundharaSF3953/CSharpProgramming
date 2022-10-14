using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleQuestion3
{
    public class SalaryInfo
    {

       

        public int SalaryOfMonth { get; set; }

        public int Month { get; set; }


        //Parameterized constructor
        public SalaryInfo(int salaryOfMonth, int month)
        {
             SalaryOfMonth=salaryOfMonth;
             Month=month;
        }
        
        
        //Salary Calculation method
        public void SalaryCalculation()
        {
           Console.WriteLine("Enter your per day salary: ");
           SalaryOfMonth=int.Parse(Console.ReadLine());
           

            if(Month==2)
            {
                // timespan1=new DateTime(2022,Month,01)-new DateTime(2022,Month,29); 
                // int days=(int)timespan1.TotalDays;
                SalaryOfMonth+=SalaryOfMonth*29; 
            }
            else if(Month==1 && Month==3 && Month==5 &&  Month==7 && Month==8 && Month==10 && Month==12)
            {
               
                SalaryOfMonth+=SalaryOfMonth*31; 

            }
            else
            {
                
                SalaryOfMonth+=SalaryOfMonth*30;   
            }
           
            
        }

        
        //Display salary method
        public void DisplaySalary()
        {
            Console.WriteLine("The salary of this month is:"+SalaryOfMonth);
        }
        
        
    }
}