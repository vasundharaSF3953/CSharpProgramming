using System;
namespace LibraryManagement;
class Program
{
    public static void Main(string[] args)
    {
        Operations.DefaultUserDetails();
        Operations.DefaultBookDetails();
        Operations.DefaultBorrowedDetails();
        Operations.MainMenu();
    }
}
