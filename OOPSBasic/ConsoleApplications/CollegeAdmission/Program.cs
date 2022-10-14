using System;
using System.Collections.Generic;
namespace CollegeAdmission;
class Program
{
    public static void Main(string[] args)
    {
        List<StudentDetails> studentList=new List<StudentDetails>();   //File or List creation 
       

        Console.WriteLine("Are you willing to join in this college");
        string willing=Console.ReadLine();

        while(willing=="yes")
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
        string gender=Console.ReadLine();
      
        
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

        Console.WriteLine("Are you willing to join in this college");
        willing=Console.ReadLine();

        }


        
        foreach(StudentDetails student in studentList)
        {

        Console.WriteLine("Student1 Details are");
        Console.WriteLine($"Name is: {student.Name} \nFather Name is: {student.FatherName} \nD.O.B: {student.DOB} \nGender: {student.Gender} \nMail: {student.Mail} \nPhoneNumber: {student.Phone} \nPhysics Mark: {student.Physics} \nChemisrty Mark: {student.Chemistry} \nMaths Mark: {student.Maths}");
        }

     
     
        while(willing=="yes")
        {
        StudentDetails student1=new StudentDetails(); //object creation for first student
        
        Console.WriteLine("Read data");
       
        //Application for printout
        Console.WriteLine("Enter the details of the candidate");

        Console.Write("Enter your Name: ");
        student1.Name=Console.ReadLine();

        Console.Write("Enter your father name: ");
        student1.FatherName=Console.ReadLine();
     

        Console.Write("Enter your Date Of Birth: ");
       student1.DOB=DateTime.ParseExact (Console.ReadLine(),"dd/MM/yyyy",null);
        

        Console.Write("Enter your Gender: ");
       student1.Gender=Console.ReadLine();
      
        
        Console.Write("Enter your Phone number: ");
        student1.Phone=long.Parse(Console.ReadLine());
      

        Console.Write("Enter your mail id: ");
      student1.Mail=Console.ReadLine();
      
        
        Console.Write("Enter your physics mark: ");
       student1.Physics=int.Parse(Console.ReadLine());
        

        Console.Write("Enter your chemistry mark: ");
        student1.Chemistry=int.Parse(Console.ReadLine());
      

        Console.Write("Enter your maths mark: ");
        student1.Maths=int.Parse(Console.ReadLine());
        
        
        studentList.Add(student1);   //We are adding object to list.
        
        Console.WriteLine("Admitted");

        Console.WriteLine("Are you willing to join in this college");
        willing=Console.ReadLine();

        }

        
        



        // StudentDetails student2=new StudentDetails();    //object creation for second student
        // Console.WriteLine("Enter the details of Second candidate");
        // Console.Write("Enter your Name: ");
        // student2.Name=Console.ReadLine();

        // Console.Write("Enter your father name: ");
        // student2.FatherName=Console.ReadLine();

        // Console.Write("Enter your Date Of Birth: ");
        // student2.DOB=DateTime.ParseExact (Console.ReadLine(),"dd/MM/yyyy",null);

        // Console.Write("Enter your Gender: ");
        // student2.Gender=Console.ReadLine();
        
        // Console.Write("Enter your Phone number: ");
        // student2.Phone=long.Parse(Console.ReadLine());

        // Console.Write("Enter your mail id: ");
        // student2.Mail=Console.ReadLine();
        
        // Console.Write("Enter your physics mark: ");
        // student2.Physics=int.Parse(Console.ReadLine());

        // Console.Write("Enter your chemistry mark: ");
        // student2.Chemistry=int.Parse(Console.ReadLine());

        // Console.Write("Enter your maths mark: ");
        // student2.Maths=int.Parse(Console.ReadLine());
        // studentList.Add(student2);


        // StudentDetails student3=new StudentDetails();      //object creation for third student
        // Console.WriteLine("Enter the details of Third candidate");
        // Console.Write("Enter your Name: ");
        // student3.Name=Console.ReadLine();

        // Console.Write("Enter your father name: ");
        // student3.FatherName=Console.ReadLine();

        // Console.Write("Enter your Date Of Birth: ");
        // student3.DOB=DateTime.ParseExact (Console.ReadLine(),"dd/MM/yyyy",null);

        // Console.Write("Enter your Gender: ");
        // student3.Gender=Console.ReadLine();
        
        // Console.Write("Enter your Phone number: ");
        // student3.Phone=long.Parse(Console.ReadLine());

        // Console.Write("Enter your mail id: ");
        // student3.Mail=Console.ReadLine();
        
        // Console.Write("Enter your physics mark: ");
        // student3.Physics=int.Parse(Console.ReadLine());

        // Console.Write("Enter your chemistry mark: ");
        // student3.Chemistry=int.Parse(Console.ReadLine());

        // Console.Write("Enter your maths mark: ");
        // student3.Maths=int.Parse(Console.ReadLine());
        // studentList.Add(student3);


      
        
        
        // Console.WriteLine("Details of Second candidate:");
        // Console.WriteLine($"Your Name is: {student2.Name}");
        // Console.WriteLine($"Your Father Name is: {student2.FatherName}");
        // Console.WriteLine($"Your Date Of Birth is: {student2.DOB}");
        // Console.WriteLine($"Your Gender is: {student2.Gender}");
        // Console.WriteLine($"Your Phone Number is: {student2.Phone}");
        // Console.WriteLine($"Your Mail Id is: {student2.Mail}");
        // Console.WriteLine($"Your Physics Mark is: {student2.Physics}");
        // Console.WriteLine($"Your Chemistry Mark is: {student2.Chemistry}");
        // Console.WriteLine($"Your Maths Mark is: {student2.Maths}");
        
        // Console.WriteLine("Details of Third candidate:");
        // Console.WriteLine($"Your Name is: {student3.Name}");
        // Console.WriteLine($"Your Father Name is: {student3.FatherName}");
        // Console.WriteLine($"Your Date Of Birth is: {student3.DOB}");
        // Console.WriteLine($"Your Gender is: {student3.Gender}");
        // Console.WriteLine($"Your Phone Number is: {student3.Phone}");
        // Console.WriteLine($"Your Mail Id is: {student3.Mail}");
        // Console.WriteLine($"Your Physics Mark is: {student3.Physics}");
        // Console.WriteLine($"Your Chemistry Mark is: {student3.Chemistry}");
        // Console.WriteLine($"Your Maths Mark is: {student3.Maths}");
        
        

        
        
        
    }
}
