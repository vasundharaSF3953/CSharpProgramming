using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalQuestion2
{
    public class TemporaryEmployee:SalaryInfo
    {
        private static int s_employeeId=2000;
        public string EmployeeId { get; set; }

        public string EmployeeType{ get; set; }

        public double DA { get; set; }

        public double HRA {get; set;}


        public double PF { get; set; }
        
        public int TotalSalary { get; set; }

        
        public  TemporaryEmployee(int basicSalary,int month,string employeeType,double da, double hra, double pf ):base(basicSalary,month)
        {
            s_employeeId++;
            EmployeeId="EID"+s_employeeId;
            DA=da;
            HRA=hra;
            PF=pf;
            
        
        }
        
        public void Calculate()
        {
            TotalSalary=TotalSalary-BasicSalary+(int)DA+(int)HRA-(int)PF;
        }

        public void ShowSalaryDetails()
        {
            Console.WriteLine("Your total salary is:"+TotalSalary);
        }
        
        
        
        
        
    }
}