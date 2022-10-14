using System;
 namespace Question10;
 class Program
 {
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any Password:");
        string password=Console.ReadLine();

        string pass="HiTeam";

        if(pass==password)
        {
           Console.WriteLine("Right Password:");
        }
        else
        {
             Console.WriteLine("Wrong Password:");
        }
        
    }
 }
