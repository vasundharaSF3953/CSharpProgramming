using System;
namespace MultiLevelQuestion1;

class Program
{
    public static void Main(string[] args)
    {

        StudentInfo student=new StudentInfo("PID1001","Vasundhara","Ganam",1234567890,"vasu@gmail.com",new DateTime(2001,07,18),Gender.Female,"Tenth","Maths",2018);
        student.ShowDetails();

        HscDetails detail=new HscDetails("RNO1001","PID101","Vasundhara","Ganam",1234567890,"vasu@gmail.com",new DateTime(2001,01,18),Gender.Female,"Tenth","Maths",2018,84,78,91,0,0);
        detail.Calculate();
        detail.ShowMarksheet();
    }
}