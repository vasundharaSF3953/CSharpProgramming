using System;
namespace Ecommerce;
class Program
{
    public static void Main(string[] args)
    {
         //Files.Create();
         Files.ReadFile();
        Operations.DefaultCustomerDetails();
        Operations.DefaultOrderDetails();
        Operations.DefaultProductDetails();
        Operations.MainMenu();
        Files.WriteToFiles();
    }
}