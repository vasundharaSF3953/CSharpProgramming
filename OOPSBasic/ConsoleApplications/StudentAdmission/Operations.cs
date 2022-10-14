using System;



namespace StudentAdmission
{
   public delegate void EventManager();  //User Defined delegates 
    public class Operations
    {
 
        public static event EventManager eventLink=null;     //User defined events

       static StudentDetails currentStudent=null;   //Object creation to store current student 
   
       public  static List<StudentDetails> StudentDetailList=new List<StudentDetails>();   //List Creation for student details
       
       public static List<AdmissionDetail> AdmissionDetailList=new List<AdmissionDetail>();   //List creation for admission details
       
        public static List<DepartmentDetail> DepartmentDetailList=new List<DepartmentDetail>(); //List creation for department details
        

        public static void  Subscribe()     //method
        {
            eventLink +=new EventManager(Files.Create);
            eventLink +=new EventManager(Files.ReadFile);
            eventLink +=new EventManager(Operations.MainMenu);
            eventLink +=new EventManager(Files.WriteToFiles);
        }

        public static void StartEvent()
        {
            Subscribe();
            eventLink();
        }

        
       
        //Main method 
        public static void MainMenu()
        {
        string choice="yes";
         
        do
        {

            Console.WriteLine("Select Options 1.Student Registration 2.Student Login 3.Cheeck Department wise seat availability 4.Exit");
            int option=int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                {
                    Console.WriteLine("Student Registration");
                    Registration();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Student Login");
                    Login();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Check Department wise seat availibility");
                    foreach(DepartmentDetail departments in DepartmentDetailList)
                    {
                        Console.WriteLine(departments.DepartmentId+"\t"+departments.DepartmentName+"\t"+departments.NumberOfSeats);
                    }
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

        //Registration Method
        public static void Registration()
        {
            Console.Write("Enter Your Name: ");
            string studentName=Console.ReadLine();
            Console.Write("Enter Your Father Name: ");
            string fatherName=Console.ReadLine();
            Console.Write("Enter your Date Of Birth: ");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write("Enter Your Gender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.Write("Enter your Physics Mark:");
            int physics=int.Parse(Console.ReadLine());
            Console.Write("Enter your Chemistry Mark:");
            int chemistry=int.Parse(Console.ReadLine());
            Console.Write("Enter your Maths Mark:");
            int maths=int.Parse(Console.ReadLine());
            StudentDetails studentObject=new StudentDetails(studentName,fatherName,dob,gender,physics,chemistry,maths);   //Object creation for student details
            StudentDetailList.Add(studentObject);   //Add object to list
            Console.WriteLine("Student added successfully");
            Console.WriteLine("Your Student id is: "+studentObject.StudentId);
            
            
        }

        //Login Method    
        public static void Login()
        {
            Console.Write("Enter Your Student Id:");
            string loginId=Console.ReadLine();

            foreach(StudentDetails student in StudentDetailList)
            {
                if(student.StudentId==loginId)
                {
                    Console.WriteLine("Login Successful");
                    currentStudent=student;
                    SubMenu();
                }
            }
            
        }

        //Submenu Method    
        public static void SubMenu()
        {
            string choice="yes";
            do
            {
                Console.WriteLine("Select Options 1.Check Eligibility 2.Show Details 3.Take Admission 4.Cancel Admission 5.Show Admission Details 6.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("Check Eligibility");
                        bool eligible=currentStudent.CheckEligiblity(75.0);  //Return boolean value is stored
                        if(eligible)
                         {
                            Console.WriteLine("Student is Eligible");
                         }
                        else
                         {
                             Console.WriteLine("Student is not Eligible");  
                         }
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Show Details");
                        currentStudent.ShowDetails();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Take Admission");
                         TakeAdmission();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Cancel Admission");
                        CancelAdmission();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("Show Admission Details");
                        foreach(AdmissionDetail admission1 in AdmissionDetailList)
                        {
                            if(currentStudent.StudentId==admission1.StudentId)
                            {
                                 admission1.ShowAdmissionDetails();
                            }
                        }
                       
                        break;
                    }
                    case 6:
                    {
                        Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
                
            }while(choice=="yes");
        }

        //TakeAdmission Method       
        public static void TakeAdmission()
        {
            //Show Department Details
             foreach(DepartmentDetail department in DepartmentDetailList)
             {
                  Console.WriteLine(department.DepartmentId+ "\t"+ department.DepartmentName+"\t"+department.NumberOfSeats);
               
             }

            //Get departmentId from user
             Console.WriteLine("Select any one of the department id listed above: ");
             string departmentId=Console.ReadLine();
             
             //Get the dept obj fron the dept list
             foreach(DepartmentDetail departments in DepartmentDetailList)
             {
                //Check departmentId contain in department list
                 if(departments.DepartmentId==departmentId)
                 {

                     //Check number of seats 
                    if(departments.NumberOfSeats>=1)
                    {

                       //Check for user eligibility
                        bool eligible=currentStudent.CheckEligiblity(75.0);  //Return boolean value is stored
                        if(eligible)
                         {
                            Console.WriteLine("Student is Eligible");
                            
                            //Check for existing admission for the student id
                            bool admit=true;
                            foreach(AdmissionDetail admission in AdmissionDetailList) 
                             {
                                if(admission.StudentId==currentStudent.StudentId)
                                {
                                    if(admission.AdmissionStatus==AdmissionStatus.Admitted)
                                    {
                                        Console.WriteLine("Student already admitted");
                                        admit=false;
                                    }
                                }

                              }
                              if(admit)
                               {
                                    departments.NumberOfSeats--;
                                    AdmissionDetail admissionObject=new AdmissionDetail(currentStudent.StudentId,departments.DepartmentId,DateTime.Now,AdmissionStatus.Booked);
                                    AdmissionDetailList.Add(admissionObject);
                                    Console.WriteLine("Admission Took Successfully");
                                    Console.WriteLine("Your admission Id is:"+admissionObject.AdmissionId);
                                    
                               }
                         }
                    }
                     
                }
             }
             
        }


        public static void CancelAdmission()
        {
            foreach(AdmissionDetail admission1 in AdmissionDetailList)
            {
               if(admission1.StudentId==currentStudent.StudentId)
                 {
                     Console.WriteLine(admission1.AdmissionId,admission1.StudentId,admission1.DepartmentId,admission1.AdmissionDate,admission1.AdmissionStatus);
                     if(admission1.AdmissionStatus==AdmissionStatus.Admitted)
                     {
                        admission1.AdmissionStatus=AdmissionStatus.Cancelled;
                        foreach(DepartmentDetail department1 in DepartmentDetailList)
                        {
                            if(department1.DepartmentId==admission1.DepartmentId)
                            {
                                    department1.NumberOfSeats++;
                                    Console.WriteLine("Seat Cancelled Successfully");
                            }
                        }
                     }
                 }
            }
          
            
        }
    
        //Method to store default students details
        public static void DefaultStudentDetails()
        {
             StudentDetails student1=new StudentDetails("Ravichandaran","Ettapparajan", new DateTime(1999,11,11), Gender.Male, 95,95,95);
             StudentDetailList.Add(student1);
             StudentDetails student2=new StudentDetails("Baskaran","Sethurajan", new DateTime(1999,11,11), Gender.Male, 95,95,95);
             StudentDetailList.Add(student2);
        }

        //Method to store default department details
        public static void DefaultDepartmentDetails()
        {
            DepartmentDetail department1=new DepartmentDetail("EEE",29);
            DepartmentDetailList.Add(department1);
            DepartmentDetail department2=new DepartmentDetail("CSE",29);
            DepartmentDetailList.Add(department2);
            DepartmentDetail department3=new DepartmentDetail("MECH",30);
            DepartmentDetailList.Add(department3);
            DepartmentDetail department4=new DepartmentDetail("ECE",30);
            DepartmentDetailList.Add(department4);
          
        }

         //Method to store default admission details
       public static void DefaultAdmissionDetails()
        {
            AdmissionDetail admission1=new AdmissionDetail("SF3001","DID102",new DateTime(2022,10,11),AdmissionStatus.Admitted);
            AdmissionDetailList.Add(admission1);
            AdmissionDetail admission2=new AdmissionDetail("SF3002","DID102",new DateTime(2022,04,11),AdmissionStatus.Admitted);
            AdmissionDetailList.Add(admission2); 
        }
    }
        
    }


