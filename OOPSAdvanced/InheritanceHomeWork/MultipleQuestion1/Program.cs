using System;

namespace MultipleQuestion1;

class Program
{
    public static void Main(string[] args)
    {
        // PersonalInfo person=new PersonalInfo("Vasundhara",Gender.Female,new DateTime(2001,07,18),044-998877,1234567899,MaritalDetails.Married);
        // person.ShowInfo();

        RegisterPerson register=new RegisterPerson("PID1","Vasundhara",Gender.Female,new DateTime(2001,07,01),1234567898,044-123456,MaritalDetails.Married,new DateTime(2001,01,09));
        register.ShowRegistrationInfo();
        register.ShowFamilyInfo("Ganam","Kavitha","369,Perumal Kovil Street",2);
    }
}
