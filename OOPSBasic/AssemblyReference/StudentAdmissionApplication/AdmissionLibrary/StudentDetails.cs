

namespace AdmissionLibrary;

public enum Gender{Default,Male,Female,TransGender}
    public class StudentDetails
    {
        //private string _name; //Field declaration

        // public string Name { get{return _name;} set{_name=value;} }

        private static int s_registerNumber=3000;     //Field creation

        public string RegisterNumber { get;  }
        
        public string Name { get; set; } //AutoProperty

        public string FatherName { get; set; }

        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }

        public long Phone { get; set; }

        public string Mail { get; set; }

        public int Physics { get; set; }

        public int Chemistry { get; set; }

        public int Maths { get; set; }
        
       

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

       

        ~StudentDetails()     //Destuctor creation
        {

        }
        
        
        
        


        
        
        
        
        
        
        
        
        
        
    }
