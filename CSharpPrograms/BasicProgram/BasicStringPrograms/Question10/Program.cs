using System;
namespace Question10;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the name of the user: ");
        string userName=Console.ReadLine();

        Console.Write("Enter the password of the user: ");
        string password=Console.ReadLine();

        int name=userName.Length;
        int word=password.Length;

        if(name==word)
        {
           Console.WriteLine("Password entered successfully!");  
        }
        else
        {
           Console.WriteLine("you have entered wrong Password");    
        }
        
    }
}
