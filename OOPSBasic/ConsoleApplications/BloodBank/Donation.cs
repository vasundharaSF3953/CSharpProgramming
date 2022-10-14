using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
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
            DonationId="DID"+s_donationId;
            DonorId=donorId;
            DonationDate=donationDate;
            Weight=weight;
            BloodPressure=bloodPressure;
            HemoglobinCount=hemoglobinCount;

        }
        
        public Donation(string data)
        {
           string[] values=data.Split(",");
           s_donationId=int.Parse(values[0].Remove(0,3));
           DonationId=values[0];
           DonorId=values[1];
           DonationDate=DateTime.ParseExact(values[2],"dd/MM/yyyy",null);
           Weight=int.Parse(values[3]);
           BloodPressure=int.Parse(values[4]);
           HemoglobinCount=float.Parse(values[5]);

        }
        
        
        
        
    }
}