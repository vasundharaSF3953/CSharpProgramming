using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelQuestion3
{
    public class EmployeeInfo:SalaryInfo
    {
        private static int s_employeeId=100;

        public string EmployeeId { get; set; }

        public int Branch { get; set; }

        public int Floor { get; set; }

        public EmployeeInfo(string personalId,string name, string fatherName, Gender gender, long mobile, DateTime dateTime,int salary, int month,int branch, int floor):base(personalId, name, fatherName, gender,mobile,dateTime, salary, month)
        {
           s_employeeId++;
           EmployeeId="EID"+s_employeeId;
           Branch=branch;
           Floor=floor;

        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine("EmployeeId: "+EmployeeId+"\n"+"Branch: "+Branch+"Floor: "+Floor);
        }
        
        
        
        
        
        
    }
}