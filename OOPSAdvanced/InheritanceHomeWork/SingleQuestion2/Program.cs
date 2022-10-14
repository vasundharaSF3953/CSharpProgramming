using System;
namespace SingleQuestion2;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person=new PersonalInfo("Vasu","Ganam",1234567890,"vino@gmail.com",new DateTime(2001,07,01),Gender.Female);   //object created for Personal info class
        

        AccountInfo account=new AccountInfo("PID101","Vino","Sekaran",1234565432,"vino#gmail.com",new DateTime(1999,09,24),Gender.Female,"Numgabakkam",3469578,5000);
        account.ShowAccountInfo();
        account.Deposite();
        account.Withdraw();
        account.ShowBalance();
    }
}
