using System;

namespace StudentData;

class Program
{
    public static void Main(string[] args)
    {
        StudentInfo.Display();
        Console.WriteLine(StudentInfo.RegisterNumber);
        StudentInfo.RegisterNumber=3955;
        Console.WriteLine(StudentInfo.RegisterNumber);
    }
}