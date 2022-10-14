using System;
namespace OperatorOverloading;

class Program
{
    public static void Main(string[] args)
    {
        Box box1=new Box(1.2,3.2,4.2);
        Box box2=new Box(5.3,5.6,6.6);
        Box box3;

        double volume=0.0;

        volume=box1.Calculate();
        Console.WriteLine("Volume of box1: "+volume);


        volume=box2.Calculate();
        Console.WriteLine("Volume of box2 : "+volume);

        box3=box1+box2;  //add two object

        volume=box3.Calculate();
        Console.WriteLine("Volume of box3 : "+volume);

    }    
}