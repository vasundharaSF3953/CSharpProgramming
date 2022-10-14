using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridQuestion2
{
    public class IdInfo:PersonalInfo  //Inherited
    {
        public long VoterID { get; set; }
        
        public long AadharID { get; set; }
        
        public long  PanNumber { get; set; }
        
        public IdInfo(string name, Gender gender, DateTime dob, long phone, long mobile,long voterId, long aadharId, long panNumber):base(name, gender, dob, phone, mobile)
        {
           
           VoterID=voterId;
           AadharID=aadharId;
           PanNumber=panNumber;
        }

        public void ShowIdDetails()
        {
            ShowPersonalInfo();
            Console.WriteLine("Vote Id Number is: "+VoterID+"\n"+"Aadhar Card number is: "+AadharID+"\n"+"Pan card number is: "+PanNumber);
        }
    }
}