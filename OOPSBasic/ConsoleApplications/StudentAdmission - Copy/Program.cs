using System;
namespace StudentAdmission;

class Program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Operations.DefaultStudentDetails();
        Operations.DefaultDepartmentDetails();
        Operations.DefaultAdmissionDetails();
        Files.ReadFile();
      
        Operations.MainMenu(); 
        Files.WriteToFiles();

    }
}
