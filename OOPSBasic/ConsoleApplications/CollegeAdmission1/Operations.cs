using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission1
{
    public static class Operations
    {
        static StudentDetails currentStudent=null;
        static List<StudentDetails> studentList=new List<StudentDetails>(); 
       public static void MainMenu()

       {

        string choice="yes";
        do{
          Console.WriteLine("Select Option 1.Registaration 2.Login 3.Exit");
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
            Console.WriteLine("Read data");
       
        //Application for printout
        Console.WriteLine("Enter the details of the candidate");

        Console.Write("Enter your Name: ");
        string name=Console.ReadLine();

        Console.Write("Enter your father name: ");
        string fatherName=Console.ReadLine();
     

        Console.Write("Enter your Date Of Birth: ");
        DateTime dob=DateTime.ParseExact (Console.ReadLine(),"dd/MM/yyyy",null);
        

        Console.Write("Enter your Gender: ");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        
      
        
        Console.Write("Enter your Phone number: ");
        long phone=long.Parse(Console.ReadLine());
      

        Console.Write("Enter your mail id: ");
        string mail=Console.ReadLine();
      
        
        Console.Write("Enter your physics mark: ");
        int physicsMark=int.Parse(Console.ReadLine());
        

        Console.Write("Enter your chemistry mark: ");
        int chemistryMark=int.Parse(Console.ReadLine());
      

        Console.Write("Enter your maths mark: ");
        int mathsMark=int.Parse(Console.ReadLine());

        StudentDetails student1=new StudentDetails(name,fatherName,dob,phone,gender,mail,physicsMark,chemistryMark,mathsMark); //object creation for first student
        studentList.Add(student1);   //We are adding object to list.
        
        Console.WriteLine("Admitted");

        Console.WriteLine();

        }
    
        public static void Login()
        {
            Console.WriteLine("Enter your Register number:");
            string registerNumber=Console.ReadLine().ToUpper();

            foreach(StudentDetails student in studentList)
            {
                if(student.RegisterNumber==registerNumber)
                {
                    Console.WriteLine("Login Successful");
                    currentStudent=student;
                    SubMenu();
                }
            }
            
        }
    
        public static void SubMenu()
        {
            string choice="yes";
            do
            {
            Console.WriteLine("Select options 1.ShowDetails 2.CheckEligibility 3.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    Console.WriteLine("Show Details");
                     currentStudent.ShowDetails(); 
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Check Eligibility");
                    bool eligible=currentStudent.CheckEligiblity(75.0);
                    if(eligible)
                     {
                        Console.WriteLine("You are eligible for admission");
                     }
                     else
                     {
                        Console.WriteLine("You are not eligible for admission");  
                     }
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Exit SubMenu");
                    choice="no";
                    break;
                }
            }

            }while(choice=="yes");
            
        }
    
    }
}