using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    public enum Gender{Male, Female, Others}
    public class Benificiary
    {
       private static int s_registrationNumber=1000; //Field Creation

       public string RegistrationNumber{ get; set; } //Property Creation

       public string Name { get; set; }
       
       public Gender Gender { get; set; }

       public long MobileNumber { get; set; }

       public string City { get; set; }

       public int Age { get; set; }
       
       //Parameterized Constructor

       public  Benificiary(string name, Gender gender, long mobileNumber, string city, int age)
       {
           s_registrationNumber++;
           RegistrationNumber="BID"+s_registrationNumber;
           Name=name;
           MobileNumber=mobileNumber;
           City=city;
           Age=age;
       } 
       
       
       
       
       
       
       
        
    }
}