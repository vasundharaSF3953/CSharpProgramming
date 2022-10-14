using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    public class Operations
    {

        static Benificiary currentBenificiary=null;     
        static List<Benificiary> BenificiaryList=new List<Benificiary>();   //Benificiary List Creation

        static List<Vaccination> VaccinationList=new List<Vaccination>();    //Vaccination List Creation

        static List<Vaccine> VaccineList=new List<Vaccine>();     //Vaccine List Creation
        

        //Mainmenu method
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                Console.WriteLine("Select Options 1.Benificiary Registration 2.Login 3.Get Vaccine Info 4.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("Benificiary Registration");
                        BenificiaryRegistration();
                        break;
                    }
                     case 2:
                    {
                        Console.WriteLine("Login");
                        Login();
                        break;
                    }
                     case 3:
                    {
                        Console.WriteLine("Get Vaccine Info");
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


      //Benificiary Registration method 
      public static void BenificiaryRegistration()
      {
           Console.WriteLine("Enter Your Name: ");
           string name=Console.ReadLine();
           Console.WriteLine("Enter Your Age: ");
           int age=int.Parse(Console.ReadLine());
           Console.WriteLine("Enter Your Gender: ");
           Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
           Console.WriteLine("Enter Your Mobile Number: ");
           long mobileNumber=long.Parse(Console.ReadLine());
           Console.WriteLine("Enter Your City: ");
           string city=Console.ReadLine();
           Benificiary benificiary3=new Benificiary(name,gender,mobileNumber,city,age);  //create object
           BenificiaryList.Add(benificiary3); //add object to list
           Console.WriteLine("Your Registration number is: "+benificiary3.RegistrationNumber);


      }

      //Login Method
      public static void Login()
      {
           Console.WriteLine("Enter your Benificiary Register Number:");
           string registerNumber1=Console.ReadLine();
           
           foreach(Benificiary benificiary1 in BenificiaryList)
           {
                if(benificiary1.RegistrationNumber==registerNumber1)
                {
                    Console.WriteLine("Login Successfull");
                    currentBenificiary=benificiary1;
                    SubMenu();
                }
           }
      }

     //Submenu method
      public static void SubMenu()
      {
        string choice="yes";
        do
        {
            Console.WriteLine("Select Options 1.Show My Details 2. Take Vaccination 3.My Vaccination History 4.Next Due Date 5.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                 case 1:
                 {
                    Console.WriteLine("Show My Details");
                    ShowMyDetails();
                    break;
                 }
                  case 2:
                 {
                    Console.WriteLine("Take Vaccination");
                    TakeVaccination();
                    break;
                 }
                  case 3:
                 {
                    Console.WriteLine("My Vacciantion History");
                    VaccinationHistory();
                    break;
                 }
                  case 4:
                 {
                    Console.WriteLine("Next Due Date");
                    NextDueDate();
                    break;
                 }
                  case 5:
                 {
                    Console.WriteLine("Exit");
                    choice="no";
                    break;
                 }
            }
            

        }while(choice=="yes");
      }


      //Show My Details Method
      public static void ShowMyDetails()
      {
        //Show the current benificiary personal details
        foreach(Benificiary benificiary in BenificiaryList)
        {
            if(currentBenificiary.RegistrationNumber==benificiary.RegistrationNumber)
            {
                Console.WriteLine(benificiary.RegistrationNumber+"\t"+benificiary.Name+"\t"+benificiary.Gender+"\t"+benificiary.MobileNumber+"\t"+benificiary.City+"\t"+benificiary.Age);
            }
        }

      }

      //Take Vacination Method
      public static void TakeVaccination()
      {
        //Show the list of vaccine available
        foreach(Vaccine vaccine1 in VaccineList)
        {
            Console.WriteLine(vaccine1.VaccineId+"\t"+vaccine1.VaccineName+"\t"+vaccine1.NoOfDoseAvailable);
        }

        //Ask user to select vaccine Id
         Console.WriteLine("Select any vaccine id shown before:");
         string vaccineId1=Console.ReadLine();
         
         foreach(Vaccination vaccination in VaccinationList)
         {
            if(vaccination.VaccineId==vaccineId1)
            {
                if(currentBenificiary.RegistrationNumber==vaccination.RegistrationNumber)
                {
                     Console.WriteLine(vaccination.VaccinationId+"\t"+vaccination.RegistrationNumber+"\t"+vaccination.VaccineId+"\t"+vaccination.DoseNumber+"\t"+vaccination.VaccinateDate);
                }

                else
            {
                if(currentBenificiary.Age>=14)
                {
                    Console.WriteLine("Select any DoseNumber:");
                    int doseNumber=int.Parse(Console.ReadLine());
                    
                    Vaccination vaccine1=new Vaccination(currentBenificiary.RegistrationNumber,vaccineId1,doseNumber,DateTime.Now);
                    VaccinationList.Add(vaccine1);

                    foreach(Vaccine vaccine in VaccineList)
                    {
                        if(vaccine.VaccineId==vaccineId1)
                        {
                            vaccine.NoOfDoseAvailable--;
                        }
                    }
                    
                }
            }
            int count=0;
            foreach(Vaccination vaccination2 in VaccinationList)
            {
                if(currentBenificiary.RegistrationNumber==vaccination2.RegistrationNumber)
                {
                  count=count+1;
                }
            }
            if(count>=3)
            {
               Console.WriteLine("All the three Vaccination course are completed you cannot be vaccinated");
            }
            else
            {
                foreach(Vaccination vaccination3 in VaccinationList)
                {
                    if(vaccination3.VaccineId==vaccineId1)
                    {
                        DateTime date1=vaccination3.VaccinateDate;
                        TimeSpan timespan=DateTime.Now-new DateTime(date1.Year,date1.Month,date1.Day);

                        int value=(int)timespan.TotalDays;
                        if(value>30)
                        {
                             Console.WriteLine("Select any DoseNumber:");
                             int doseNumber=int.Parse(Console.ReadLine());
                    
                             Vaccination vaccine2=new Vaccination(currentBenificiary.RegistrationNumber,vaccineId1,doseNumber,DateTime.Now);
                             VaccinationList.Add(vaccine2);
                               
                            foreach(Vaccine vaccine in VaccineList)
                               {
                                 if(vaccine.VaccineId==vaccineId1)
                                  {
                                     vaccine.NoOfDoseAvailable--;
                                  }
                                }

                        }
                        else
                        {
                            Console.WriteLine("You have selected different vaccine");
                        }

                    }
                }
            }

           
         }
      }
      }

      //Vaccination History Details
      public static void VaccinationHistory()
      {
        //show the vaccination details of current benificiary
        foreach(Vaccination vaccination1 in VaccinationList)
        {
            if(currentBenificiary.RegistrationNumber==vaccination1.RegistrationNumber)
            {
                Console.WriteLine(vaccination1.VaccinationId +"\t"+ vaccination1.RegistrationNumber +"\t"+ vaccination1.VaccineId +"\t"+ vaccination1.DoseNumber+"\t"+  vaccination1.VaccinateDate);
            }
        }
      }

      //Next Due Date Method
      public static void NextDueDate()
      {
        int count=0;
        foreach(Vaccination vaccinatin2 in VaccinationList)
        {
            if(currentBenificiary.RegistrationNumber==vaccinatin2.RegistrationNumber)
            {
                  count=count+1;
            }
        }
        if(count>=3)
        {
           Console.WriteLine("You have completed the vaccination course. Thanks for your participation in the vaccine drive"); 
        }
        else if(count>=1 && count<=2)
        {
            foreach(Vaccination vaccinatin2 in VaccinationList)
        {
            if(currentBenificiary.RegistrationNumber==vaccinatin2.RegistrationNumber)
            {
                DateTime date1=vaccinatin2.VaccinateDate;
                Console.WriteLine("Your next availibility date is :"+date1.AddDays(30));
            }
        }
             
        }
        else
        {
            Console.WriteLine("You can take the vaccine now");
        }
      }
       
      //Get Vaccine Info Method

      public static void GetVaccineInfo()
      {
          foreach(Vaccine vaccine in VaccineList)
          {
              Console.WriteLine(vaccine.VaccineName+"\t"+vaccine.NoOfDoseAvailable);
          }
      }

       //Default method for Benificiary
       public static void DefaultBenificiaryDetails()
       {
        Benificiary benificiary1=new Benificiary("Ravichandaran",Gender.Male,8484484,"Chennai",21);
        BenificiaryList.Add(benificiary1);
        Benificiary benificiary2=new Benificiary("Baskaran",Gender.Male,8484774,"Chennai",21);   //Object creation
        BenificiaryList.Add(benificiary2);  //Add object to list
       }

       //Default method for Vaccine details
       public static void DefaultVaccineDetails()
       {
            Vaccine vaccine1=new Vaccine(VaccineName.Covishekd,50);
            VaccineList.Add(vaccine1);
            Vaccine vaccine2=new Vaccine(VaccineName.Covishekd,50);   //Object Creation
            VaccineList.Add(vaccine2);  //Add  Object to list
       }

        //Default method for vaccaination details
       public static void DefaultVaccinationDetails()
       {
           Vaccination vaccination1=new Vaccination("BID1001","CID101",1,new DateTime(2021,11,11));
           VaccinationList.Add(vaccination1);
           Vaccination vaccination2=new Vaccination("BID1001","CID101",2,new DateTime(2022,03,11));
           VaccinationList.Add(vaccination2);
           Vaccination vaccination3=new Vaccination("BID1002","CID102",1,new DateTime(2022,04,04));
           VaccinationList.Add(vaccination3);
       }
    
    }
}