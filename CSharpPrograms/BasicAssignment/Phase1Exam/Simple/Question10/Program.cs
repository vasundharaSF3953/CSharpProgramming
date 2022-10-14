using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any character:");
        char letter=char.Parse(Console.ReadLine());

        if((letter=='a'|| letter=='e'|| letter=='i'|| letter=='o'|| letter=='u')||(letter=='A'|| letter=='E'|| letter=='I'|| letter=='O'|| letter=='U'))
        {
            Console.WriteLine("It is a vowel");
        }
        else
        {
            Console.WriteLine("It is not  a vowel");
        }
    }
}
