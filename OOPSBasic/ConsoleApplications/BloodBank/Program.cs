using System;
namespace BloodBank;
class Program
{
    public static void Main(string[] args)
    {
        //Files.Create();    //Call the create method before the Mainmenu method to create the files and folders first
        Files.ReadFile();
        Operations.MainMenu();
        Files.WriteFile();
    }
}
