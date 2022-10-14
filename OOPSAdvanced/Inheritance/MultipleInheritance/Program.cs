using System;
namespace MultipleInheritance;

class Program
{
    public static void Main(string[] args)
    {
        
  
     PersonalDetails person=new PersonalDetails("vasundhara","Ganam",Gender.Female,1234567890);
     person.ShowDetails(); 

     StudentDetails student=new StudentDetails("456789","Vasundhara","Ganam",Gender.Female,456789,Department.EEE,"one");  
     student.ShowStudentDetails();
     student.GetMark(90,90,90);
     student.Calculate();
     student.ShowMark();

     CustomerDetails customer=new CustomerDetails("456789","Vasundhara","GanaSekaran",Gender.Female,123456789);
     customer.ShowDetail();
     customer.Recharge();

        
    }
}
