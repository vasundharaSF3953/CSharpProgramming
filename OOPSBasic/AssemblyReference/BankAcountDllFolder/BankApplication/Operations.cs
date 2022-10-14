using System;
using System.Collections.Generic;
using BankLibrary;

namespace BankOperations;
public class Operations
{
    public static void MainMenu()
    {

        List<AccountDetails> accountList=new List<AccountDetails>();  //File or List creation

        Console.Write("Do you want to create the new account ");
        string data=Console.ReadLine().ToLower();


        while(data=="yes")
        {

        Console.WriteLine("Enter your Basic details");
        
        Console.Write("Enter your Name:");
        string name=Console.ReadLine();

        Console.Write("Enter your Father Name:");
        string fatherName=Console.ReadLine();

        Console.Write("Enter your Gender:");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        
        
        Console.Write("Enter your Date Of Birth:");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        Console.Write("Enter your Account Type:");
        AccountType accountType=Enum.Parse<AccountType>(Console.ReadLine(),true);

        Console.WriteLine("Admitted");
        
        AccountDetails accountCreation=new AccountDetails(name,fatherName,dob,gender,accountType);      //Object Creation 
        accountList.Add(accountCreation);   //add object to list

        Console.Write("Do you want to create the new account ");
        data=Console.ReadLine().ToLower();
        
        } 

        foreach(AccountDetails account in accountList)
        {
            Console.WriteLine("Your account Details are");
            Console.WriteLine($"your Name: {account.Name} \nYour Father Name: {account.FatherName} \nYour D.O.B: {account.DOB.ToString("dd/MM/yyyy")} \nYour Gender: {account.Gender} \nYour Account Type: {account.AccountType}");
            account.Deposite();
            account.Withdraw();
            account.ShowBalance();
        }


        
        // Console.WriteLine("Enter your Balance:");
        // double balance=double.Parse(Console.ReadLine());
    


        
        
    }
}