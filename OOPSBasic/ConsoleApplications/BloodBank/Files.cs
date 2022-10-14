using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace BloodBank
{
    public class Files
    {
        public static void Create()       //Create method to create folder and files
        {
            if(!Directory.Exists("BloodBankManagement"))       //Folder Creation
            {
                Console.WriteLine("Creating Foder");
                Directory.CreateDirectory("BloodBankManagement");
            }

            if(!File.Exists("Donation"))         
            { 
                Console.WriteLine("Creating File");          //Files Creation
                File.Create("BloodBankManagement/Donation.csv");
            }

            if(!File.Exists("UserRegistration"))
            {
                Console.WriteLine("Creating File");          //Files Creation
                File.Create("BloodBankManagement/UserRegistration.csv");
            }
        }


        public static void ReadFile()      //Method to read file content
        {
            string[] donation=File.ReadAllLines("BloodBankManagement/Donation.csv");
            foreach(string data in donation)
            {
                Donation donation1=new Donation(data);
                Operations.DonationList.Add(donation1);
            }

            string[] user=File.ReadAllLines("BloodBankManagement/UserRegistration.csv");
            foreach(string  data1 in user)
            {
                UserRegistration user1=new UserRegistration(data1);
                Operations.UserRegistrationsList.Add(user1);
            }

        }


        public static void WriteFile()
        {
            string[] donation=new string[Operations.DonationList.Count];
            for(int i=0;i<Operations.DonationList.Count;i++)
            {
              donation[i]=Operations.DonationList[i].DonationId+","+Operations.DonationList[i].DonorId+","+Operations.DonationList[i].DonationDate.ToString("dd/MM/yyyy")+","+Operations.DonationList[i].Weight+","+Operations.DonationList[i].BloodPressure+","+Operations.DonationList[i].HemoglobinCount;
            }
            File.WriteAllLines("BloodBankManagement/Donation.csv",donation);


            string[] user=new string[Operations.UserRegistrationsList.Count];
            for(int i=0; i<Operations.UserRegistrationsList.Count;i++)
            {
                user[i]=Operations.UserRegistrationsList[i].DonorId+","+Operations.UserRegistrationsList[i].DonorName+","+Operations.UserRegistrationsList[i].MobileNumber+","+Operations.UserRegistrationsList[i].BloodGroup+","+Operations.UserRegistrationsList[i].Age+","+Operations.UserRegistrationsList[i].LastDonation.ToString("dd/MM/yyyy");
            }
            File.WriteAllLines("BloodBankManagement/UserRegistration.csv",user);
        }
    }
}