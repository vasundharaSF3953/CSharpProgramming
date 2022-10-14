using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleQuestion3
{
    public enum Gender{Female, Male, TransGender}
    public class PersonalInfo
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public DateTime DOB { get; set; }
        
        public long Phone { get; set; }
        
        public long Mobile { get; set; }
        
        public int PAN { get; set; }
        
        public PersonalInfo(string name, DateTime date1, long phone, long mobile,int pan)
        {
           Name=name;
           DOB=date1;
           Phone=phone;
           Mobile=mobile;
           PAN=pan;
        }

        public void ShowPersonalInfo()
        {
            Console.WriteLine("Name: "+Name+"\n"+"Date Of Birth: "+DOB+"\n"+"Phone: "+Phone+"\n"+"Mobile: "+Mobile+"\n"+"PAN: "+PAN);
        }
        
        
    }
}