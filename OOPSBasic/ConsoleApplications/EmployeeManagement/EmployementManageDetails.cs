using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public enum WorkLocation{Default, Madura, Eymard}
    public enum Gender{Default, Female, Male, TransGender}
    public class EmployementManageDetails
    {
        
        private static int s_employeeId=1000;

        public string EmployeeID  { get; }

        public string EmployeeName  { get; set; }

        public string Role { get; set; }

        public WorkLocation WorkLocation { get; set; }

        public string TeamName { get; set; }

        public DateTime DateOfJoining { get; set; }

        public int WorkingDays { get; set; }

        public int LeaveTaken { get; set; }

        public Gender Gender { get; set; }
        
        public EmployementManageDetails(string employeeName,string role,WorkLocation workLocation,String teamName,DateTime dateOfJoining, Gender gender)
        {
            s_employeeId++;
            EmployeeID="SF"+s_employeeId;
            EmployeeName=employeeName;
            Role=role;
            WorkLocation=workLocation;
            TeamName=teamName;
            DateOfJoining=dateOfJoining;
            Gender=gender;


        }

        public void CalculateSalary()
        {
            int salary=(WorkingDays-LeaveTaken)*500;
            Console.WriteLine("Your Salary for this month is:"+salary);
        }
        
        public void ShowDetails()
        {
            Console.WriteLine("Details of Employee are");
            Console.WriteLine($"EmployeeId: {EmployeeID} \nEmployee Name: {EmployeeName} \nRole: {Role} \nTeamName: {TeamName} \nWork Location: {WorkLocation} \nDate Of Joining: {DateOfJoining.ToString("dd/MM/yyyy")} \nGender: {Gender}");
        }
        
        public void NumberOfLeave()
        {
            Console.Write("Enter the Working days of the Employee :");
            WorkingDays=int.Parse(Console.ReadLine());
            Console.Write("Enter the leave taken by the Employee :");
            LeaveTaken=int.Parse(Console.ReadLine());
        }
        
        
        
        
    }
}