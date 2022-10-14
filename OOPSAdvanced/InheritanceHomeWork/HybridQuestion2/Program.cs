using System;
namespace HybridQuestion2;

class Program
{
    public static void Main(string[] args)
    {
        //   IdInfo id=new IdInfo("Vasundhara",Gender.Female,new DateTime(2001,07,01),1234567890,2211334455,6677888877,434365657898,9999999);
        //  id.ShowIdDetails();


        SavingAccount saving=new SavingAccount("HDFC",12345678,"HdfcBranch","Vasundhara",Gender.Female,new DateTime(2000,08,04),1234567890,4444,443355667788,66776677,111111,AccountType.Savings);
        saving.ShowSavingsDetails();
        saving.Deposite();
        saving.Withdraw();
        saving.BalanceCheck();


      
    }
}
