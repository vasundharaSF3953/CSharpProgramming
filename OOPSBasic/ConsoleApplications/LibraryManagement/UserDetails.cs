using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{

    public enum Departments{ECE, EEE, CSE}
    public class UserDetails
    {
        private static int s_registrationId=3000;     //Field Creation

        public string RegistrationId{ get; set; }    //Property Creation

        public string Name { get; set; }
        
        

        public string Gender { get; set; }
        
        public Departments Department { get; set; }


        public long MobileNumber { get; set; }

        public string MailId { get; set; }
        
        //Parameterized Constructor Creation
        public UserDetails(String name,string gender, Departments department,long mobileNumber, string mailId)
        {
            s_registrationId++;
            RegistrationId="SF"+s_registrationId;
            Name=name;
            Gender=gender;
            Department=department;
            MobileNumber=mobileNumber;
            MailId=mailId;

        }
        
        
        
        
        
        
        
        
    }
}