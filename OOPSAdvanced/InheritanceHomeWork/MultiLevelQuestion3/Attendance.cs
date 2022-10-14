using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelQuestion3
{
    public class Attendance
    {
        public DateTime Date1 { get; set; }

        public int NumberOfHours { get; set; }

        

        public Attendance(DateTime date1,int hours)
        {
             Date1=date1;
             NumberOfHours=hours;
        }
        
        public void ShowAttendanceDetails()
        {
            Console.WriteLine("Date: "+Date1+"\n"+"Hours: "+NumberOfHours);
        }
        
        
        
        
    }
}