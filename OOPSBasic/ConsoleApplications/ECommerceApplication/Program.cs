using System;
namespace ECommerceApplication;
class Program
{
    public static void Main(string[] args)
    {
        Operations.DefaultCustomerDetails();
        Operations.DefaultOrderDetails();
        Operations.DefaultProductDetails();
        Operations.MainMenu();
    }
}