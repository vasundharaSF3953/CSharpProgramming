using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Operations
    {
        static EmployementManageDetails currentEmployee=null;
        static List<EmployementManageDetails> EmployeeList=new List<EmployementManageDetails>();
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                Console.WriteLine("Select options 1.Registration 2.Login 3.Exit");
                int options=int.Parse(Console.ReadLine());

                switch(options)
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
        
        Console.WriteLine("Basic Detail of Employee");    
        Console.Write("Enter the Name of the Employee :");
        string employeeName=Console.ReadLine();
        Console.Write("Enter the Role of the Employee :");
        string role=Console.ReadLine();
        Console.Write("Enter the Work Location of the Employee :");
        WorkLocation workLocation=Enum.Parse<WorkLocation>(Console.ReadLine(),true);
        Console.Write("Enter the Team Name of the Employee :");
        string teamName=Console.ReadLine();
        Console.Write("Enter the Date of Joining of the Employee :");
        DateTime dateOfJoining=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        Console.Write("Enter Your Gender :");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        Console.WriteLine("Admitted");
        

        EmployementManageDetails Employee=new EmployementManageDetails(employeeName,role,workLocation,teamName,dateOfJoining,gender); //Object Creation
        EmployeeList.Add(Employee); //Add object to list
        }
    
        public static void Login()
        {
            Console.WriteLine("Enter your Employee Id:");
            string empID=Console.ReadLine();
            
            foreach(EmployementManageDetails employee in EmployeeList)
            {
                if(employee.EmployeeID==empID)
                {
                    Console.WriteLine("Login Successfully");
                     currentEmployee=employee;
                     SubMenu();

                }
            }
        }
  
        public static void SubMenu()
        {
            string choice="yes";
            do
            {
                Console.WriteLine("Select options 1.Show Details 2.Number Of Leave 3.Calculate Salary 4.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("Show Details");
                        currentEmployee.ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Number of Leave");
                        currentEmployee.NumberOfLeave();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Calculate Salary");
                        currentEmployee.CalculateSalary();
                        break;
                    }
                    case 4:
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