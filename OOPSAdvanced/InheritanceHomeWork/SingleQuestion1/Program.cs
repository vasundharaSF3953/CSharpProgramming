using System;
namespace SingleQuestion1;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person=new PersonalInfo("Vasu","Ganam",1234567890,"vasu@gmail.com",new DateTime(2001,05,18),Gender.Female);  //Object creation for personalInfo class
        person.ShowInfo();

        StudentInfo student=new StudentInfo("PID101","Vino","Sekaran",1236789463,"vino@gmail.com",new DateTime(2003,02,19),Gender.Female,"Tenth","Maths",2020);    //Object is created for student info
        student.UpdateInfo();  //get the particular method from that class
    }
}
