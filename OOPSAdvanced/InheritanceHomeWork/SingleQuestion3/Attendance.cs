using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleQuestion3
{
    public class Attendance
    {
       

        public DateTime Date1 { get; set; }

        public int NumberOfHoursWorked { get; set; }


        //Constructor creation
        public Attendance(DateTime date1, int numberOfHoures)
        {
           
            Date1=date1;
            NumberOfHoursWorked=numberOfHoures;
        }

        public void AttendanceDetails()
        {
            Console.WriteLine("Enter the number of hours worked: ");
            NumberOfHoursWorked=int.Parse(Console.ReadLine());
            
        }

       



        
        
        
        
        
        
    }
}