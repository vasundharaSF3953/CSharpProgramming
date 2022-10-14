using System;


namespace StudentAdmission
{
    public enum Gender{Default, Male, Female, TransGender}    //Initialize the Enum data type
    public class StudentDetails
    {

       private static int s_studentId=3000;      //Field Creation

       public string StudentId { get; set; }     //Property Creation
      
       public string StudentName { get; set; }   //Property Creation

       public string FatherName { get; set; }

       public DateTime DOB { get; set; }

       public Gender Gender{ get; set;}

       public int Physics{ get; set; }

       public int Chemistry { get; set; }
       
       public int Maths { get; set; }

        //Constructor Creation
       public StudentDetails(string studentName,string fatherName,DateTime dob,Gender gender, int physics,int chemistry,int maths)  //Parameterized constructor creation
       {
         s_studentId++;
         StudentId="SF"+s_studentId;
         StudentName=studentName;
         FatherName=fatherName;
         DOB=dob;
         Gender=gender;
         Physics=physics;
         Chemistry=chemistry;
         Maths=maths;
       }

       public StudentDetails(string data)
       {
         string[] values=data.Split(',');
         s_studentId=int.Parse(values[0].Remove(0,2));
         StudentId=values[0];
         StudentName=values[1];
         FatherName=values[2];
         DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
         Gender=Enum.Parse<Gender>(values[4]);
         Physics=int.Parse(values[5]);
         Chemistry=int.Parse(values[6]);
         Maths=int.Parse(values[7]);

       }
       
      

       public bool CheckEligiblity(double cutOff)     //Method creation to check eligibility
        {
            double average=(double)(Physics+Chemistry+Maths)/3;
            if(average>=cutOff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public void ShowDetails()      //Method creation to show students details
       {
           Console.WriteLine("Your Basic Details are:");
           Console.WriteLine($"Student ID: {StudentId} \nName: {StudentName} \nFather Name: {FatherName} \nDateOfBirth: {DOB.ToString("dd/MM/yyyy")} \nGender: {Gender} \nPhysics Mark: {Physics} \nChemistry Mark: {Chemistry} \nMaths Mark: {Maths}");
       }

       
       
       
       
        
    }
}