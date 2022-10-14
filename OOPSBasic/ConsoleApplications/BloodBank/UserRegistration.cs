using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{

    public enum BloodGroup{A_Positive, B_Positive, O_Positive, AB_Positive}
    public class UserRegistration
    {
         private static int s_donorId=1000;   //Field Creation

         public string DonorId { get; set; }  //Property

         public string DonorName { get; set; }

         public long MobileNumber { get; set; }

         public BloodGroup BloodGroup{ get; set; }

         public int Age { get; set; }

         public DateTime LastDonation { get; set; }
         

         //Parameterized Constructor creation
        public UserRegistration(string donorName, long mobileNumber,BloodGroup bloodGroup, int age, DateTime lastDonation) 
        {
              s_donorId++;
              DonorId="DID"+s_donorId;
              DonorName=donorName;
              MobileNumber=mobileNumber;
              BloodGroup=bloodGroup;
              Age=age;
              LastDonation=lastDonation;
        }


        public UserRegistration(string data)
        {
            string[] values=data.Split(',');
            s_donorId=int.Parse(values[0].Remove(0,3));
             DonorId=values[0];
             DonorName=values[1];
             MobileNumber=long.Parse(values[2]);
             BloodGroup=Enum.Parse<BloodGroup>(values[3]);
             Age=int.Parse(values[4]);
             LastDonation=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);

        }


        public  void GetDonationDetails()
        {
            Console.WriteLine(DonorId+"\t"+DonorName+"\t"+MobileNumber+"\t"+BloodGroup+"\t"+Age+"\t"+LastDonation);
        }
         
          public  void NextDonationDate()
        {

             
                    DateTime date2=DateTime.Now.AddDays(60);
                    Console.WriteLine("Your Next eligible date is :"+date2.ToString("dd/MM/yyyy"));
                
        }
         
         
         
         
         
         
         
         
    }
}