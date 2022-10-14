using System;
namespace HybridQuestion3;

class Program
{
    public static void Main(string[] args)
    {
        RegistrationApplication register=new RegistrationApplication("Vasundhara",Gender.Female,new DateTime(2001,07,18),1234565432,2233445566,"Ganam","Kavitha","369,PerumalKovil street","BE","CSE",88,89,98,99,2,"Sports");
        register.ShowRegistrationDetails();
    }
}
