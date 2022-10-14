using System;
namespace HybridQuestion1;

class Program
{
    public static void Main(string[] args)
    {
        Marksheet mark=new Marksheet("Vasundhara","Ganam",1234567899,new DateTime(2006,11,16),Gender.Female,81,91,87,90,new DateTime(2022,10,09),0,0);
        mark.CalculateUG();
    }
}
