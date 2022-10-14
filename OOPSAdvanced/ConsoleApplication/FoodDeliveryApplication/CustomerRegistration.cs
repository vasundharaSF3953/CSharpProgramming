using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApplication
{
    public class CustomerRegistration:PersonalDetails,IBalance
    {
       private static int s_customerID=1000;   //Field

       public string CustomerID { get; set; }
       
       public int WalletBalance { get; set; }

      
       
       
       
        public CustomerRegistration(string name, string fatherName, string gender, long mobile,DateTime dob, string mailId, string location,int walletBalance):base(name, fatherName, gender, mobile, dob, mailId, location)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            WalletBalance=walletBalance; 
        }


        public CustomerRegistration(string data):base(data)
        {
            string[] values=data.Split(','); 
            s_customerID=int.Parse(values[0].Remove(0,3));
            CustomerID=values[0];
            WalletBalance=int.Parse(values[1]); 
        
        }


        public void ShowCustomerDetails()
        {
            Console.WriteLine("CustomerID: "+CustomerID+"\n"+"WalletBalance: "+WalletBalance);
            ShowPersonalDetails();
        }

        public void WalletRecharge()
        {
            Console.WriteLine("Available Wallet balance is: "+WalletBalance);
            Console.Write("Enter the amount to be recharged: ");
            WalletBalance+=int.Parse(Console.ReadLine());
            Console.WriteLine("Current Available balance is: "+WalletBalance);
            
        }
    }
}