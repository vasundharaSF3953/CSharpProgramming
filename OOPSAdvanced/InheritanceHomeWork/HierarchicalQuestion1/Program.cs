using System;
namespace HierarchicalQuestion1;

class Program
{
    public static void Main(string[] args)
    {
        Teacher teacher1=new Teacher("PID1001","Vasu","Ganam",new DateTime(2022,10,14),1234567890,Gender.Female,"vasu@gmail.com","TamilDepartment","Tamil","BA",5,new DateTime(2022,09,12));
        teacher1.showTeacherDetails();

        StudentInfo student=new StudentInfo("PID1002","Vasu","Ganam",new DateTime(2001,05,07),1234567890,Gender.Female,"vasu@gmail.com","BA","Literarure",9);
        student.ShowStudentInfo();

        PrincipalId principal=new PrincipalId("PID1003","Indhu","Mari",new DateTime(2022,09,12),1234567890,Gender.Female,"indhu@gmail.com","BA","Literature",8,new DateTime(2022,04,12));
        principal.ShowPrincipalDetails();
    }
}