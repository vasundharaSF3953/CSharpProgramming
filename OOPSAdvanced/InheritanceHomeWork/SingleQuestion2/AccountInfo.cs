using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleQuestion2
{
    public class AccountInfo:PersonalInfo     //Inherited
    {
        private static int s_accountNumber=1000;   //Field Creation

        public string AccountNumber { get; set; }   //Property Creation

        public string BranchName { get; set; }

        public int IFSCCode { get; set; }

        public double Balance { get; set; }



        //AccountInfo Method
        public AccountInfo(string personId, string name, string fatherName,long phoneNumber, string mailId,DateTime dob,Gender gender,string branchName, int ifsccode, double balance):base( personId, name, fatherName,phoneNumber, mailId,dob,gender)     //Property inherited
        {
              s_accountNumber++;
              AccountNumber="ANO"+s_accountNumber;
              BranchName=branchName;
              IFSCCode=ifsccode;
              Balance=balance;
        }


        public void ShowAccountInfo()
        {
            Console.WriteLine("Account Details");
            Console.WriteLine("Account Number: "+AccountNumber);
            Console.WriteLine("IFSCCode: "+IFSCCode);
            Console.WriteLine("Branch Name:"+BranchName);
            showDetails();       //Method Inherited from personalInfo class
                
        }

        //Deposite method
        public void Deposite()
        {
            Console.WriteLine("Enter teh amount need to be deposited:");
            double deposite=double.Parse(Console.ReadLine());
            Balance=Balance+deposite;

        }


        //Withdraw Method
        public void Withdraw()
        {
            Console.WriteLine("Enter teh amount need to be withdraw:");
            double withdraw=double.Parse(Console.ReadLine());
            Balance=Balance-withdraw;

        }


        //Balance Method
        public void ShowBalance()
        {
            Console.WriteLine("Your current available balance is: "+Balance);
        }
        
        
        
        
        
        
        
        
        
    }
}