using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleQuestion3
{
    public enum Account{Savings, Balance}
    public class RecurringDeposit
    {
        private static int s_accountNumber=1000;

        public Account AccountType { get; set; }
        
        public string AccountNumber { get; set; }

        public int Balance { get; set; }
        
         public RecurringDeposit(Account account)
        {
            s_accountNumber++;
            AccountNumber="ANO"+s_accountNumber;
            AccountType=account;
        }

        public void ShowRecurringAccount()
        {
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