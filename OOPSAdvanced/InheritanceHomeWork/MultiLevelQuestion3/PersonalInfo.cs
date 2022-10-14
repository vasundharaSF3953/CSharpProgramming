using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelQuestion3
{
    public enum Gender{Female, Male, TransGender}
    public class PersonalInfo
    {
       private static int s_personalId=100;

       public string PersonalId{ get; set; }

       public string Name { get; set; }

       public string FatherName { get; set; }

       public Gender Gender { get; set; }


       public long Mobile { get; set; }

       public DateTime DOB { get; set; }


       public PersonalInfo(string name, string fatherName, Gender gender, long mobile, DateTime dateTime)
       {
        s_personalId++;
        PersonalId="PID"+s_personalId;
        Name=name;
        FatherName=fatherName;
        Gender=gender;
        Mobile=mobile;

       }

        public PersonalInfo(string personalId,string name, string fatherName, Gender gender, long mobile, DateTime dateTime)
       {
        
        PersonalId=personalId;
        Name=name;
        FatherName=fatherName;
        Gender=gender;
        Mobile=mobile;

       }


       public void ShowPersonalDetails()
       {
           Console.WriteLine("PersonId: "+PersonalId+"\n"+"Name: "+Name+"\n"+"Father Name:"+FatherName+"Gender: "+Gender+"Mobile: "+Mobile+"Date Of Birth: "+DOB);
       }
       
       
       
       
       
       
       
       
       
       
       
        
    }
}