using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class CustomerDetails
    {
        private static int s_customerId=1000;

        public string CustomerId { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public long MobileNumber { get; set; }

        public int WalletBalance { get; set; }

        public string EmailId { get; set; }

        public CustomerDetails(string name, string city, long mobileNumber, int walletBalance, string emailId)
        {
           
           s_customerId++;
           CustomerId="CID"+s_customerId;
           Name=name;
           City=city;
           MobileNumber=mobileNumber;
           WalletBalance=walletBalance;
           EmailId=emailId;
        }
        
        
        public CustomerDetails(string data)
        {
            string[] values=data.Split(',');
            s_customerId=int.Parse(values[0].Remove(0,3));
            CustomerId=values[0];
            Name=values[1];
            City=values[2];
            MobileNumber=long.Parse(values[3]);
            WalletBalance=int.Parse(values[4]);
            EmailId=values[5];

        }
        
        
        
        
        
        
        
        
        
    }
}