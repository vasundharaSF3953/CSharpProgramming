using System;
namespace HierarchicalInheritance;

class Program
{
    public static void Main(string[] args)
    {
        
  
     PersonalDetails person=new PersonalDetails("vasundhara","Ganam",Gender.Female,1234567890);
     person.ShowDetails(); 

     StudentDetails student=new StudentDetails("456789","Vasundhara","Ganam",Gender.Female,456789,Department.EEE,"one");  
     student.ShowStudentDetails();

     CustomerDetails customer=new CustomerDetails("456789","Vasundhara","GanaSekaran",Gender.Female,123456789);
     customer.ShowDetail();

        
    }
}
