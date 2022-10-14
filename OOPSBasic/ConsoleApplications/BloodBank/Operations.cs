using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public class Operations
    {
        static UserRegistration currentDonor=null;
        public static List<Donation> DonationList=new List<Donation>();  //Donation List Creation

         public static List<UserRegistration> UserRegistrationsList=new List<UserRegistration>();  //User Donation List Creation

         public static void MainMenu()
         {
            string choice="yes";
            do
            {
                Console.WriteLine("Select options 1.User Registration 2.User Login 3.Fetch Donor Details 4.Exit ");
                int options=int.Parse(Console.ReadLine());

                switch(options)
                {
                    case 1:
                    {
                        Console.WriteLine("User Registration");
                        Registration();
                        break;
                    }
                     case 2:
                    {
                        Console.WriteLine("User Login");
                        Login();
                        break;
                    }
                     case 3:
                    {
                        Console.WriteLine("Fetch Donor Details");
                        FetchDonorDetail();
                        break;
                    }
                     case 4:
                    {
                        Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
                

            }while(choice=="yes");
         }
    
         public static void Registration()
         {
            Console.Write("Enter your name:");
            string donorName=Console.ReadLine();
            Console.Write("Enter your Mobile Number:");
            long mobileNumber=long.Parse(Console.ReadLine());
            Console.Write("Enter your Age:");
            int age=int.Parse(Console.ReadLine());
            Console.Write("Enter your Blood Group:");
            BloodGroup bloodGroup=Enum.Parse<BloodGroup>(Console.ReadLine(),true);
            Console.Write("Enter your Last donation date: ");
            DateTime lastDonation=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            UserRegistration register=new UserRegistration(donorName,mobileNumber,bloodGroup,age,lastDonation);  //object creation for user registration
            UserRegistrationsList.Add(register);   //Add object to list
            Console.WriteLine("Your Donor Id is: "+register.DonorId);
            
        }

        public static void Login()

        {
            Console.WriteLine("Enter your Donor Id:");
            string donorId=Console.ReadLine();

            foreach(UserRegistration register in UserRegistrationsList)
            {
                if(donorId==register.DonorId)
                {
                   Console.WriteLine("Login User");
                   currentDonor=register;
                   SubMenu();
                }
                else
                {
                    Console.WriteLine("Invalid UserId");
                }
            }
            

        }
    
        public static void SubMenu()
        {
            string choice="yes";
            do
            {

                Console.WriteLine("select options 1.Donate Blood 2.Donation History 3.Next Eligible Date 4.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("Donate Blood");
                        DonateBlood();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Donate History");
                        DonationHistory();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Next Eligible Date");
                        currentDonor.NextDonationDate();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
                

            }while(choice=="yes");
        }
    
        public static void DonateBlood()
        {
            Console.Write("Enter your Weight ");
            int weight=int.Parse(Console.ReadLine());
            Console.Write("Enter your Blood Pressure: ");
            int bloodPressure=int.Parse(Console.ReadLine());
             Console.Write("Enter your HemoglobinCount ");
            int hemoglobinCount=int.Parse(Console.ReadLine());

            if(weight>50 && bloodPressure>130 && hemoglobinCount>13)
            {
                
                  DateTime date1=currentDonor.LastDonation.AddDays(60);
                    if(date1<=DateTime.Now)
                    {
                        Donation donation1=new Donation(currentDonor.DonorId,DateTime.Now,weight,bloodPressure,hemoglobinCount);
                        DonationList.Add(donation1);
                    }
                    DateTime currentDate=DateTime.Now;
                    Console.WriteLine("Blood Donated Successfully");
                    Console.WriteLine("Your Donation ID is : "+currentDonor.DonorId);
                    Console.WriteLine("your next eligible date of donation is:"+currentDate.AddDays(60).ToString("dd/MM/yyyy"));
               
            }

        }
    
        public static void DonationHistory()
        {
            foreach(Donation donate in DonationList)
            {
                if(currentDonor.DonorId==donate.DonorId)
                {
                    Console.WriteLine(donate.DonationId+"\t"+donate.DonorId+"\t"+donate.DonationDate.ToString("dd/MM/yyyy")+"\t"+donate.Weight+"\t"+donate.BloodPressure+"\t"+donate.HemoglobinCount);
                }
            }
        }
    
        // public static void NextDonationDate()
        // {

        //      foreach(UserRegistration registration in UserRegistrationsList)
        //      {
        //         if(currentDonor.DonorId==registration.DonorId)
        //         {
        //             DateTime date2=registration.LastDonation.AddDays(60);
        //             Console.WriteLine("Your Next eligible date is :"+date2);
        //         }
        //      }
        // }
        
        public static void FetchDonorDetail()
        {
            Console.WriteLine("Enter your Blood Group:");
            BloodGroup bloodGroup=Enum.Parse<BloodGroup>(Console.ReadLine(),true);
            foreach(UserRegistration registration in UserRegistrationsList)
            {
                if(registration.BloodGroup==bloodGroup)
                {
                    Console.WriteLine(registration.DonorName+"\t"+registration.MobileNumber);
                }
            }
            
        }
    }
}