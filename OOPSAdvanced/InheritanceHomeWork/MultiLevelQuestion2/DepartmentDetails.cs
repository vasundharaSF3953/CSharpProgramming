using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelQuestion2
{
    public class DepartmentDetails
    {
        public string DepartmentName { get; set; }    //Property Creation

        public string Degree { get; set; }
        
        //Parameterized constructor
        public DepartmentDetails(string departmentName, string degree)
        {
            DepartmentName=departmentName;
            Degree=degree;
        }


        //Show Details method
        public void showDepartmentDetails()
        {
            Console.WriteLine("Department Name: "+DepartmentName+"\n"+"Degree: "+Degree);
        }
        
    }
}