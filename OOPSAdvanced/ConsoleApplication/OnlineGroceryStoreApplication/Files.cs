using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace OnlineGroceryStoreApplication
{
    public class Files
    {
        public static void Create()
        {
            //creating  Folder
            if(!Directory.Exists("OnlineGroceryStore"))
            {
                Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("OnlineGroceryStore");
            }

            //Creating Files for customer registration
            if(!File.Exists("OnlineGroceryStore/CustomerRegistration.csv"))
            {
                Console.WriteLine("Creating Folder");
                File.Create("OnlineGroceryStore/CustomerRegistration.csv");
            }

            //Creating Files for order details
            if(!File.Exists("OnlineGroceryStore/OrderDetails.csv"))
            {
                Console.WriteLine("Creating Folder");
                File.Create("OnlineGroceryStore/OrderDetails.csv");
            }

            //creating file for product details
            if(!File.Exists("OnlineGroceryStore/ProductDetails.csv"))
            {
                Console.WriteLine("Creating Folder");
                File.Create("OnlineGroceryStore/ProductDetails.csv");  
            }

            //creating file for booking detail
            if(!File.Exists("OnlineGroceryStore/BookingDetails.csv"))
            {
                Console.WriteLine("Creating Folder");
                File.Create("OnlineGroceryStore/BookingDetails.csv");  
            }


        }

        public static void ReadFile()
        {
            string[] customer=File.ReadAllLines("OnlineGroceryStore/CustomerRegistration.csv");
            foreach(string data in customer)
            {
                   CustomerRegistration customer1=new CustomerRegistration(data);
                   Operations.customerList.Add(customer1);
            }


           string[] order=File.ReadAllLines("OnlineGroceryStore/OrderDetails.csv");
           foreach(string data in order)
           {
               OrderDetails order1=new OrderDetails(data);
               Operations.orderList.Add(order1);
           }

           string[] product=File.ReadAllLines("OnlineGroceryStore/ProductDetails.csv");
           foreach(string data in product)
           {
               ProductDetails product1=new ProductDetails(data);
               Operations.productList.Add(product1);
           }

           string[] booking=File.ReadAllLines("OnlineGroceryStore/BookingDetails.csv");
           foreach(string data in booking)
           {
             BookingDetails booking1=new BookingDetails(data);
           }
        }

        public static void WriteToFiles()
        {
            string[] customer=new string[Operations.customerList.Count];
            for(int i=0; i<Operations.customerList.Count; i++)
            {
                customer[i]=Operations.customerList[i].CustomerId+","+Operations.customerList[i].Name+","+Operations.customerList[i].FatherName+","+Operations.customerList[i].Gender+","+Operations.customerList[i].MobileNumber+","+Operations.customerList[i].DOB.ToShortDateString()+Operations.customerList[i].MailId;
            }
            File.WriteAllLines("OnlineGroceryStore/CustomerRegistration.csv",customer);


            string[] product= new string[Operations.productList.Count];
            for(int i=0; i<Operations.productList.Count; i++)
            {
                product[i]=Operations.productList[i].ProductId+","+Operations.productList[i].ProductName+","+Operations.productList[i].QuantityAvailable+","+Operations.productList[i].PricePerQuantity;
            }
            File.WriteAllLines("OnlineGroceryStore/ProductDetails.csv",product);

            string[] order= new string[Operations.orderList.Count];
            for(int i=0; i<Operations.orderList.Count; i++)
            {
                order[i]=Operations.orderList[i].OrderId+","+Operations.orderList[i].BookingId+","+Operations.orderList[i].ProductId+","+Operations.orderList[i].PurchaseCount+","+Operations.orderList[i].PriceOfOrder;
            }
            File.WriteAllLines("OnlineGroceryStore/OrderDetails.csv",order);

            string[] booking=new string[Operations.bookingList.Count];
            for(int i=0;i<Operations.bookingList.Count; i++)
            {
                booking[i]=Operations.bookingList[i].BookingId+","+Operations.bookingList[i].CustomerId+","+Operations.bookingList[i].TotalPrice+","+Operations.bookingList[i].DateOfBooking.ToShortDateString()+","+Operations.bookingList[i].Status;
            }
            File.WriteAllLines("OnlineGroceryStore/BookingDetails.csv",booking);
        }
    }
}