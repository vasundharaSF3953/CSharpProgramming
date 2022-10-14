using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class CustomerDetails:PersonalDetails
    {
        private static int s_coutomerID=1000;
        public string CustomerId { get; set; }

        public string Balance { get; set; }
        
        public CustomerDetails(string aid,string name,string fatherName, Gender gender, long phoneNumber):base(aid, name, fatherName, gender, phoneNumber)
        {
            s_coutomerID++;
            CustomerId="cid"+s_coutomerID;
        }
        
        public void Recharge()
        {
            System.Console.WriteLine("Enter the amount to recharge:");
            Balance+=double.Parse(Console.ReadLine());
            
        }
        public void ShowDetail()
            {
                System.Console.WriteLine("CistomerId:"+CustomerId);
                ShowDetails();
                System.Console.WriteLine("Balance:"+Balance);
            }
        
        
    }
}