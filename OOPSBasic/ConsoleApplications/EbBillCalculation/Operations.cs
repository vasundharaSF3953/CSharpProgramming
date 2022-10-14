using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbBillCalculation
{
    public class Operations
    {
        static BillCalculation currentUser=null;
        static List<BillCalculation> EbBillList=new List<BillCalculation>(); //List or File Creation
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                Console.WriteLine("select options 1.Registration 2.Login 3.Exit");
                int options=int.Parse(Console.ReadLine());

                switch(options)
                {
                   case 1:
                   {
                       Console.WriteLine("Registration");
                       Registration();
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
                       Console.WriteLine("Exit");
                       choice="no";
                       break;
                   }
                }
                

            }while(choice=="yes");
        }
    
        public static void Registration()
        {
              
        Console.WriteLine("Basic Details of Person");
        Console.Write("Enter Your Name: ");
        string userName=Console.ReadLine();
        Console.Write("Enter Your Phone Number: ");
        long phoneNumber=long.Parse(Console.ReadLine());
        Console.Write("Enter Your MailId: ");
        string mailId=Console.ReadLine();
       


        BillCalculation Bill=new BillCalculation(userName,phoneNumber,mailId); //object Creation
        EbBillList.Add(Bill);  //Add object ti list
        }
    
        public static void Login()
        {
            Console.WriteLine("Enter your Meter Id:");
            string meterID=Console.ReadLine();
            
            foreach(BillCalculation bill in EbBillList)
            {
                if(bill.MeterId==meterID)
                {
                    Console.WriteLine("Login Successfully");
                    currentUser=bill;
                    SubMenu();
                }
            }
        }
   
        public static void SubMenu()
        {

            string choice="yes";
            do
            {
                Console.WriteLine("select options 1.Show Details 2.Get number of units 3.Calculate Bill 4.Exit");
                int options=int.Parse(Console.ReadLine());

                switch(options)
                {
                    case 1:
                    {
                        Console.WriteLine("Show Details");
                        currentUser.ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Get number of units");
                        currentUser.NumberOfUnits();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Calculate Bill");
                        currentUser.CalculateAmount();
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
    }
}