using System;
namespace ParticialClass;
class Program
{
    public static void Main(string[] args)
    {
        StudentDetails student=new StudentDetails("Vasundhara","Ganam",new DateTime(2022,12,11),1234567890,Gender.Female,"vasu@2001",98,99,85);
        student.ShowDetails();

    }
}
