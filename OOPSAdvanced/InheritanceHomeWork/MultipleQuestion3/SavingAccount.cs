using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleQuestion3
{
    public enum AccountType{Savings, Balance}
    public class SavingAccount:PersonalInfo,ICalculate
    {
        private static int s_accountNumber=100;

        public string AccountNumber { get; set; }

        public AccountType AccountType { get; set; }

        public int Balance {get; set;}


        public SavingAccount(string name, DateTime date1, long phone, long mobile,int pan,AccountType account):base(name, date1, phone, mobile, pan)
        {
            s_accountNumber++;
            AccountNumber="ANO"+s_accountNumber;
            AccountType=account;
        }

        public void ShowSavingsAccount()
        {
            ShowPersonalInfo();
            Console.WriteLine("AccountNumber: "+AccountNumber+"\n"+"AccountType: "+AccountType);
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
            Console.WriteLine("Current Balance is: "+Balance);
        }
        
        
        
        


    }
}