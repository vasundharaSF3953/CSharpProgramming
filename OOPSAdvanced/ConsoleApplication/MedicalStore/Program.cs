using System;
namespace MedicalStore;
class Program
{
    public static void Main(string[] args)
    {
        Files.create();
        Files.ReadFile();
        Operations.DefaultMedicineDetaila();
        Operations.DefaultOrderDetails();
        Operations.DefaultUserDetails();
        Operations.MainMenu();
        Files.writeToFiles();
    }
}
