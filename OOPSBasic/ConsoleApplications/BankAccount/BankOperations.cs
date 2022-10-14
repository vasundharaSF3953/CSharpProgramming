using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankOperations
    {
        static AccountDetails accountPerson=null;
        static List<AccountDetails> accountList=new List<AccountDetails>();
        public static void MainMenu()
        {

            string choice="yes";
            do
            {
                Console.WriteLine("Select the options 1.Registration 2.Login 3.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
                

            }while(choice=="yes");


        }
    
        public static void Registration()
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

        }
    
        public static void Login()
        {
            Console.WriteLine("Enter your account number:");
            string acNumber=Console.ReadLine();

             foreach(AccountDetails account in accountList)
             {

               if(acNumber==account.AccountNumber)
               {
                  Console.WriteLine("Login Successfull");
                  accountPerson=account;
                  SubMenu();
               }
            
        }
   
    }

        public static void SubMenu()
        {
            string choice="yes";
            do
            {
                Console.WriteLine("select options 1.Show Details 2.Deposite 3.Withdraw 4.Show Balance 5.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("Show Details");
                        accountPerson.showDetails();
                        break;
                    }
                    
                    case 2:
                    {
                        Console.WriteLine("Deposite");
                        accountPerson.Deposite();
                        break;
                    }
                    
                    case 3:
                    {
                        Console.WriteLine("withdraw");
                        accountPerson.Withdraw();
                        break;
                    }
                    
                    case 4:
                    {
                        Console.WriteLine("Show Balance");
                        accountPerson.ShowBalance();
                        break;
                    }
                    
                    case 5:
                    {
                        Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
                
            }while(choice=="yes");
        }

}
}