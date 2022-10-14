using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalQuestion1
{
    public class PrincipalId:PersonalInfo
    {
        private static int s_principalId=1000;

        public string PrincipalId1 { get; set; }

        public string Qualification { get; set; }

        public int YearOfExperience { get; set; }

        public DateTime DateOfJoining { get; set; }

        public PrincipalId(string personalId,string name, string fatherName, DateTime dob, long phoneNumber,Gender gender, string mail,string qualification, int yearOfExperience, DateTime dateOfJoining):base(personalId,name, fatherName, dob, phoneNumber,gender, mail)
        {
            s_principalId++;
            PrincipalId1="PID"+s_principalId;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }
        
        public void ShowPrincipalDetails()
        {
            System.Console.WriteLine("PrincipalId:"+PrincipalId1);
            ShowPersonalDetails();
            Console.WriteLine("Qualification:"+Qualification+"\n"+"YearOfJoining:"+YearOfExperience+"\n"+"DateOfJoining:"+DateOfJoining);
        }
        
        
        
        
        
        
    }
}