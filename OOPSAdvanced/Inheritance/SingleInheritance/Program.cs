using System;
namespace SingleInheritance;

class Program
{
    public static void Main(string[] args)
    {
        
    
     PersonalDetails person=new PersonalDetails("Vasundhara","fatherName",Gender.Female,123456789);
     person.ShowDetails(); 

     StudentDetails student=new StudentDetails("456789","Vasundhara","Ganam",Gender.Female,456789,Department.EEE,"one");  
     student.ShowStudentDetails();
        
    }
}
