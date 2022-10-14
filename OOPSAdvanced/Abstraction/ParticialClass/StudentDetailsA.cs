using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParticialClass
{
    public partial class StudentDetails
    {
        public StudentDetails(string name,string fatherName, DateTime  dob, long phone, Gender gender, string mail, int physicsMark, int chemistryMark, int mathsMark)    //Parameter Constructor 
        {
            s_registerNumber++;
            RegisterNumber="SF"+s_registerNumber;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Mail=mail;
            Phone=phone;
            Physics=physicsMark;
            Chemistry=chemistryMark;
            Maths=mathsMark;

        }
    }
}