using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridQuestion2
{
    public enum AccountType{Savings,Balance}
    public class SavingAccount:IdInfo,ICalculate
    {
        private static int s_accountNumber=10000;

        public string AccountNumber { get; set; }
        
        public AccountType Account { get; set; }

        public int Balance { get; set; }
        
        
        
        public SavingAccount(string bankName, long ifscNumber, string branch,string name, Gender gender, DateTime dob, long phone, long mobile,long voterId, long aadharId, long panNumber,AccountType account):base(name, gender, dob, phone, mobile,voterId, aadharId, panNumber)
        {
            s_accountNumber++;
            AccountNumber="ANO"+s_accountNumber;
            Account=account;
        }

        public void ShowSavingsDetails()
        {
            ShowIdDetails();
            Console.WriteLine("AccountNumber: "+AccountNumber+"\n"+"AccountType: "+Account);
        }


        public void Deposite()
        {
            Console.WriteLine("Enter the amount need to be deposite: ");
            int deposite=int.Parse(Console.ReadLine());
            Balance=Balance+deposite;
            
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter the amount need to be withdraw: ");
            int withdraw=int.Parse(Console.ReadLine());
            Balance=Balance-withdraw;
            
        }

        public void BalanceCheck()
        {
            Console.WriteLine("Current balance amount in your account is: "+Balance);
        }
    }
}