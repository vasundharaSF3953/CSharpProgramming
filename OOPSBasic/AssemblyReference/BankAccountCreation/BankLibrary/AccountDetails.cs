using System;


namespace BankLibrary
{
    public enum Gender{Default, Male, Female, TransGender}
    public enum AccountType{Default, SB, FD, RD}
    public class AccountDetails
    {
        
        private static int s_accountNumber=0000;

        public string AccountNumber { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public Gender Gender { get; set; }

        public DateTime DOB { get; set; }

        public AccountType AccountType { get; set; }

        public double Balance { get; set; }
        
        
        public AccountDetails(string name, string fatherName, DateTime dob, Gender gender,AccountType accountType)
        {
            s_accountNumber++;
            AccountNumber="xxxxxxxx"+s_accountNumber;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            AccountType=accountType;


        }

         public void Deposite()
        {
            Console.WriteLine("Enter the amount need to deposite:");
            Double amount=double.Parse(Console.ReadLine());
            Balance=Balance+amount;

            
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter the amount need to withdraw:");
            double amount=double.Parse(Console.ReadLine());
            Balance=Balance-amount;


        }
        
        public void ShowBalance()
        {
            Console.WriteLine("Your balance amount is:"+Balance);
        }

        // ~AccountDetails()     //Destructor creation
        // {

        // }
        
        
        
        
        
        
        
        
        
    }
}