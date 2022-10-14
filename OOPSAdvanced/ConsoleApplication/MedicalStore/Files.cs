using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace MedicalStore
{
    public class Files
    {
        public static void create()
        {
            if(!Directory.Exists("OnlineMedicalStore"))
            {
                Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("OnlineMedicalStore");
            }

            if(!File.Exists("OnlineMedicalStore/UserDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("OnlineMedicalStore/UserDetails.csv");
            }

             if(!File.Exists("OnlineMedicalStore/MedicineDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("OnlineMedicalStore/MedicineDetails.csv");
            }

             if(!File.Exists("OnlineMedicalStore/OrderDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("OnlineMedicalStore/OrderDetails.csv");
            }
        }

        //Reading a file
        public static void ReadFile()
        {
            string[] userDetails=File.ReadAllLines("OnlineMedicalStore/UserDetails.csv");
            foreach(string data in userDetails)

            {
               UserDetails user=new UserDetails(data);
               Operations.userDetailsList.Add(user);
            }

            string[] medical=File.ReadAllLines("OnlineMedicalStore/MedicineDetails.csv");
            foreach(string data in medical)

            {
               MedicineDetails medicine=new MedicineDetails(data);
               Operations.medicineDetailsList.Add(medicine);
            }

            
            string[] orderDetails=File.ReadAllLines("OnlineMedicalStore/OrderDetails.csv");
            foreach(string data in orderDetails)

            {
               OrderDetails orderData=new OrderDetails(data);
               Operations.orderDetailsList.Add(orderData);
            }

        }


        //Write the content to the file
        public static void writeToFiles()
        {
            string[] userDetails=new string[Operations.userDetailsList.Count];
            for(int i=0; i<Operations.userDetailsList.Count; i++)
            {
                userDetails[i]=Operations.userDetailsList[i].UserId+","+Operations.userDetailsList[i].UserName+Operations.userDetailsList[i].Age+","+Operations.userDetailsList[i].City+","+Operations.userDetailsList[i].PhoneNumber+","+Operations.userDetailsList[i].Balance;
            }
            File.WriteAllLines("OnlineMedicalStore/UserDetails.csv",userDetails);

            string[] medicineDetails=new string[Operations.medicineDetailsList.Count];
            for(int i=0; i<Operations.medicineDetailsList.Count; i++)
            {
                medicineDetails[i]=Operations.medicineDetailsList[i].MedicineId+","+Operations.medicineDetailsList[i].MedicineName+","+Operations.medicineDetailsList[i].AvailableCount+","+Operations.medicineDetailsList[i].Price+","+Operations.medicineDetailsList[i].DateOfExpiry.ToShortDateString();
            }
            File.WriteAllLines("OnlineMedicalStore/MedicineDetails.csv",medicineDetails);

            string[] orderDetails=new string[Operations.orderDetailsList.Count];
            for(int i=0; i<Operations.orderDetailsList.Count; i++)
            {
                orderDetails[i]=Operations.orderDetailsList[i].OrderId+","+Operations.orderDetailsList[i].UserId+","+Operations.orderDetailsList[i].MedicineId+","+Operations.orderDetailsList[i].MedicineCount+","+Operations.orderDetailsList[i].TotalPrice+","+Operations.orderDetailsList[i].OrderDate.ToShortDateString();
            }
            File.WriteAllLines("OnlineMedicalStore/OrderDetails.csv",orderDetails);


        }
    }
}