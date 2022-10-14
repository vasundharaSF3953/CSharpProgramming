using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{
    public class CustomerRegistration:PersonalDetails,IBalance
    {
        private static int s_customerId=1000;
        public string CustomerId { get;  }

        public double WalletBalance { get; set; }
        
        public CustomerRegistration(string name, string fatherName, Gender gender, long mobileNumber, DateTime dob, string mailID):base(name, fatherName, gender, mobileNumber, dob, mailID)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            
       
        }

        public CustomerRegistration(string data):base(data)
        {
            string[] value=data.Split(',');
             s_customerId=int.Parse(value[0].Remove(0,3));
            CustomerId=value[0];
            

        }

        public void WalletRecharge()
        {
            Console.WriteLine("Enter the amount need to be recharge:");
            WalletBalance +=int.Parse(Console.ReadLine());
            Console.WriteLine("Your current wallet balance is: "+WalletBalance);

            
        }

        public void ShowCustomerDetails()
        {
            Console.Write("CustomerId: "+CustomerId+"\t");
            ShowPersonalDetails();
            Console.WriteLine("WalletBalance: "+WalletBalance);
            
        }
        
        
    }
}