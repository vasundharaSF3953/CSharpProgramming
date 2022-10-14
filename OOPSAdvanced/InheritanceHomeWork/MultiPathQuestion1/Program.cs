using System;
namespace MultiPathQuestion1;

class Program
{
    public static void Main(string[] args)
    {
        PgCouncelling councelling1=new PgCouncelling(434453446344,"Vasu","Ganam",1234567890,new DateTime(2001,07,01),Gender.Female,99,78,81,"HSC1001",80,72,85,91,"UG1001",new DateTime(2022,10,12),500);
        councelling1.ShowCouncellingDetails();
        councelling1.ShowHscMarksheet();
        councelling1.CalculateHSC();
        councelling1.ShowUgMarkSheet();
        councelling1.CalculateUg();
    }
}
