using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagement
{

    public class Donation
    {
        private static int s_donationId=1000;  //Field Creation

        public string DonationId { get; set; }    //Property Creation
        
        public string DonorId { get; set; }

        public DateTime DonationDate { get; set; }
        
        public int Weight { get; set; }

        public int BloodPressure { get; set; }

        public float HemoglobinCount { get; set; }
        

        //Parameterized constructor creation
        public Donation(string donorId, DateTime donationDate, int weight, int bloodPressure, int hemoglobinCount)
        {
            s_donationId++;
            DonationId=DonationId+s_donationId;
            DonorId=donorId;
            DonationDate=donationDate;
            Weight=weight;
            BloodPressure=bloodPressure;
            HemoglobinCount=hemoglobinCount;

        }
        
        
        
        
        
        
    }
}