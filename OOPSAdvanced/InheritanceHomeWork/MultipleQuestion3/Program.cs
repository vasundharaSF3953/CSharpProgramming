using System;

namespace MultipleQuestion3;

class Program
{
    public static void Main(string[] args)
    {
        SavingAccount savings=new SavingAccount("Vasundhara",new DateTime(2001,07,18),1234567899,9988776655,2234225,AccountType.Savings);
        savings.ShowSavingsAccount();
        savings.Deposite();
        savings.Withdraw();
        savings.BalanceCheck();


        RecurringDeposit recurring=new RecurringDeposit(Account.Savings);
        recurring.ShowRecurringAccount();
        recurring.Deposite();
        recurring.Withdraw();
        recurring.BalanceCheck();
    }
}
