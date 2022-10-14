using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Used to process the college admission using this application
/// </summary>
namespace CollegeAdmission1;

/// <summary>
/// Used to select the student's gender information
/// </summary>
public enum Gender{Default,Male,Female,TransGender}
    public class StudentDetails
    {
        //private string _name; //Field declaration
        // public string Name { get{return _name;} set{_name=value;} }  //Property Creation


        /// <summary>
        /// Static field used to auto increment and it uniquely identify an instance of
        /// <see cref="StudentDetails"/>class
        /// </summary>
        private static int s_registerNumber=3000;     //Field creation

        /// <summary>
        /// Property RegisterNumber used to uniquely identify a <see cref="StudentDetails"/> class's object
        /// </summary>
       

        public string RegisterNumber { get;  }

        /// <summary>
        /// Property Name used to provide name for a student in object of <see cref="StudentDetails"/> class's object
        /// </summary>
       
         
        public string Name { get; set; } //AutoProperty

        /// <summary>
        /// Property FatherName used to provide father's name of a student 
        /// </summary>
       

        public string FatherName { get; set; }

        /// <summary>
        /// Property DOB used to provide date of birth of the student
        /// </summary>
     

        public DateTime DOB { get; set; }

        /// <summary>
        /// Property Gender used to provide the particular gender of the student
        /// </summary>
       

        public Gender Gender { get; set; }

        /// <summary>
        /// Property Phone used to provide the phone number of the student
        /// </summary>
       

        public long Phone { get; set; }

        /// <summary>
        /// Property Mail used to provide the mail id of the student
        /// </summary>
     
       
        public string Mail { get; set; }

        /// <summary>
        /// Property Physics used to provide the physics mark of the student
        /// </summary>
      

        public int Physics { get; set; }

        /// <summary>
        /// Property  Chemistry used to provide the chemistry mark of the student
        /// </summary>
        

        public int Chemistry { get; set; }

        /// <summary>
        /// Property Maths used to provide the Maths Mark of the student
        /// </summary>
        /// <value></value>

        public int Maths { get; set; }
        
       /// <summary>
       /// Constructor of <see cref="StudentDetails"/> class used to intialize values to its properties
       /// </summary>
       /// <param name="name">Parameter name used to initialize a Student's Name to Name property</param>
       /// <param name="fatherName">Parameter fatherName used to initialize a Student's Father's Name to FatherName property</param>
       /// <param name="dob">Parameter dob used to initialize a Student's date of birth to DOB property</param>
       /// <param name="phone">Paramete phone used to initialize a Student's phone number to Phone property</param>
       /// <param name="gender">Parameter gender used to initialize a Studen's gender to Gender property</param>
       /// <param name="mail">Parameter mail used to initialize a Student's mail id to Mail Property</param>
       /// <param name="physicsMark">Parameter physicsMark used to initialize a Student's physics mark to Physics property</param>
       /// <param name="chemistryMark">Parameter chemistyMark used to initialize a Student's chemistry mark to Chemistry property</param>
       /// <param name="mathsMark">Parameter mathsMark used to initialize a Student's maths mark to Maths property</param>

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

        /// <summary>
        /// Methd check eligibility get cutOff value as a parameter and check the eligibility of student
        /// If cutOff is less or equal then he is eligible and return true or false
        /// </summary>
        /// <param name="cutOff">Used to provide cutOff value for eligiblity checking</param>
        /// <returns>Returns true if eligible else false</returns>

        public bool CheckEligiblity(double cutOff)
        {
            double average=(double)(Physics+Chemistry+Maths)/3.0;
            if(average>=cutOff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// Show the details of Student's Name, student's Father's Name, Student's DOB, Student's Gender,Student's MailID, Student's PhoneNumber, Student's Physics Mark, Student's Chemistry Mark and Student's Maths Mark
        /// </summary>

       public  void ShowDetails()
       {
        Console.WriteLine("Student1 Details are");
        Console.WriteLine($"Name is: {Name} \nFather Name is: {FatherName} \nD.O.B: {DOB} \nGender: {Gender} \nMail: {Mail} \nPhoneNumber: {Phone} \nPhysics Mark: {Physics} \nChemisrty Mark: {Chemistry} \nMaths Mark: {Maths} \nRegisterNumber: {RegisterNumber}" );
       }
       

        ~StudentDetails()     //Destuctor creation
        {

        }
        
        
        
        


        
        
        
        
        
        
        
        
        
        
    }
