using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParticialClass
{
    public partial class StudentDetails
    {

        
        public  void ShowDetails()
       {
        Console.WriteLine("Student1 Details are");
        Console.WriteLine($"Name is: {Name} \nFather Name is: {FatherName} \nD.O.B: {DOB} \nGender: {Gender} \nMail: {Mail} \nPhoneNumber: {Phone} \nPhysics Mark: {Physics} \nChemisrty Mark: {Chemistry} \nMaths Mark: {Maths} \nRegisterNumber: {RegisterNumber}" );
       }  
    }
}