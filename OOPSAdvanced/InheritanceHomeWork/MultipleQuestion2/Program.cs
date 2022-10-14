using System;
namespace MultipleQuestion2;

class Program
{
    public static void Main(string[] args)
    {
        ShiftDezire shift=new ShiftDezire("Petrol",5,"Red",500,5,1122,"Good");
        shift.ShowShiftDezire();
        shift.ShowDetails("TATA","Car");

        Eco eco=new Eco("Petrol",5,"Blue",500,5,2233,"car new model");
        eco.ShowEcoDetails();
        eco.ShowDetails("TATA","Small");
    }
}
