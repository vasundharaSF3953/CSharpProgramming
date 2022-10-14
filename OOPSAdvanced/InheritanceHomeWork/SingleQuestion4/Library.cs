using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleQuestion4
{
    public enum Department{Default, CSE, ECE, EEE}
    public class Library
    {
        public Department DepartmentsName { get; set; }   //Property Creation

        public string Degree{ get; set; }


        //Constructor Creation
        public Library(Department departmentsName, string degree)
        {
            DepartmentsName=departmentsName;
            Degree=degree;
        }

       


        //ShowDetails Method
        public void ShowDetails()
        {
            Console.WriteLine("DepartmentsName:"+DepartmentsName);
            Console.WriteLine("Degree:"+Degree);
        }
        
        
        
        
    }
}