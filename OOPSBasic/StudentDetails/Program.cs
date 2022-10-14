using System;
namespace StudentsDetail;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Name:");
        String name=Console.ReadLine();

        Console.WriteLine("Enter Your Father's Name:");
        String fatherName=Console.ReadLine();

        Console.WriteLine("Enter Your mail id:");
        String mailId=Console.ReadLine();

        Console.WriteLine("Enter Your Phone Number:");
        long number=long.Parse(Console.ReadLine());
       
        Console.WriteLine("Enter Your Age:");
        int age=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Your Gender:");
        Char gender=Char.Parse(Console.ReadLine());

        Console.WriteLine("Enter Your Physics Mark:");
        int physics=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Your Chemisry Mark:");
        int chemistry=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Your Maths Mark:");
        int maths=int.Parse(Console.ReadLine());

        int totalMark= physics+chemistry+maths;

        float average=(float)totalMark/3;

        Console.WriteLine("Your average mark is :" +average);

        float percentage=(float)totalMark/600*100;

        Console.WriteLine("Your percentage is :" +percentage+"%");

        
              



        




    }
}