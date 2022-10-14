using System;


namespace MultiLevelQuestion1
{

    public enum Gender{Female,Male}
    public class PersonalInfo
    {
        private static int s_personalId=100;  //Field Creation

        public string PersonalId { get; set; }  //PropertyCreation

        public string Name { get; set; }
        
        
        public string FatherName { get; set; }
        
        public long Phone { get; set; }

        public string Mail { get; set; }
        
        
        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }
        
        //Constructor creation
        public PersonalInfo(string name, string fatherName, long phoneNumber, string mailId, DateTime dob, Gender gender)
        {
            s_personalId++;
            PersonalId="PID"+s_personalId;
            Name=name;
            FatherName=fatherName;
            Phone=phoneNumber;
            Mail=mailId;
            DOB=dob;
            Gender=gender;
        }


        public PersonalInfo(string personalId, string name, string fatherName, long phoneNumber, string mailId, DateTime dob, Gender gender)
        {
           
            PersonalId=personalId;
            Name=name;
            FatherName=fatherName;
            Phone=phoneNumber;
            Mail=mailId;
            DOB=dob;
            Gender=gender;  
        }

        public void ShowDetails()
        {
            Console.WriteLine("PersonalId: "+PersonalId+"\n"+"Name: "+Name+"\n"+"FatherName: "+FatherName+"\n"+"Phone: "+Phone+"\n"+"MailId: "+Mail+"\n"+"DateOfBirth: "+DOB.ToShortDateString()+"\n"+"Gender: "+Gender);
        }
        
        
    }
}