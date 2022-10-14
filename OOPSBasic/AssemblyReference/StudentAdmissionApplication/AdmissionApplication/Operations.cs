using System;
using System.Collections.Generic;
using AdmissionLibrary;
namespace AdmissionApplications;
public class Operations
{
    public static void MainMenu()
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

        Console.WriteLine("Are you willing to join in this college");
        willing=Console.ReadLine();

        }


        
        foreach(StudentDetails student in studentList)
        {

        Console.WriteLine("Student1 Details are");
        Console.WriteLine($"Name is: {student.Name} \nFather Name is: {student.FatherName} \nD.O.B: {student.DOB} \nGender: {student.Gender} \nMail: {student.Mail} \nPhoneNumber: {student.Phone} \nPhysics Mark: {student.Physics} \nChemisrty Mark: {student.Chemistry} \nMaths Mark: {student.Maths} \nRegisterNumber: {student.RegisterNumber}" );
        bool eligible=student.CheckEligiblity(75.0);
        if(eligible)
        {
           Console.WriteLine("You are eligible for admission");
        }
        else
        {
           Console.WriteLine("You are not eligible for admission");  
        }
        }

     

        
        



        
        
    }
}
