using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridQuestion2
{

    public enum Gender{Female, Male, TransGender}
    public class PersonalInfo
    {
       public string Name { get; set; }


       public Gender Gender { get; set; }


       public DateTime DOB { get; set; }
       
       public long Phone { get; set; }

       public long Mobile { get; set; }
       
       
       public PersonalInfo(string name, Gender gender, DateTime dob, long phone, long mobile)
       {
           Name=name;
           Gender=gender;
           DOB=dob;
           Phone=phone;
           Mobile=mobile;

       }

       public void ShowPersonalInfo()
       {
          Console.WriteLine("Name is: "+Name+"\n"+"Gender: "+Gender+"\n"+"Date Of Birth: "+DOB.ToShortDateString()+"\n"+"Phone: "+Phone+"\n"+"Mobile: "+Mobile);
       }
       
       
       
       
        
    }
}