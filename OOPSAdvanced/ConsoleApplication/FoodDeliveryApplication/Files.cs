using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace FoodDeliveryApplication
{
    public class Files
    {
        public static void Create()
        {
            //Folder creating
            if(!Directory.Exists("FoodDelivery"))
            {
                Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("FoodDelivery");
            }

            //Files creating
            if(!File.Exists("FoodDelivery/CustomerRegistration.csv"))
            {
                Console.WriteLine("Creating Files");
                File.Create("FoodDelivery/CustomerRegistration.csv");
            }

            //File creating
            if(!File.Exists("FoodDelivery/FoodDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("FoodDelivery/FoodDetails.csv");
            }

            //File Creating
            if(!File.Exists("FoodDelivery/OrderDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("FoodDelivery/OrderDetails.csv");
            }

            //File creating
            if(!File.Exists("FoodDelivery/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("FoodDelivery/BookingDetails.csv");
            }
        }


        //Reading a file
        public static void ReadFile()
        {
            //Read file for customerRegistration 
            string[] customer=File.ReadAllLines("FoodDelivery/CustomerRegistration.csv");
            foreach(string data in customer)
            {
                CustomerRegistration customer1=new CustomerRegistration(data);
                Operations.registrationList.Add(customer1);
            }

            //Read file for food details
            string[] food=File.ReadAllLines("FoodDelivery/FoodDetails.csv");
            foreach(string data in food)
            {
                FoodDetails food1=new FoodDetails(data);
                Operations.foodList.Add(food1);
            }

            //Read file for order details
            string[] order=File.ReadAllLines("FoodDelivery/OrderDetails.csv");
            foreach(string data in order)
            {
                OrderDetails order1=new OrderDetails(data);
                Operations.orderList.Add(order1);
            }

            //Read file for book details
            string[] book=File.ReadAllLines("FoodDelivery/BookingDetails.csv");
            foreach(string data in book)
            {
                BookingDetails book1=new BookingDetails(data);
                Operations.bookingList.Add(book1);
            }
        }


        public static void WriteToFiles()
        {
            //write content to customer registration file
            string[] customer=new string[Operations.registrationList.Count];
            for(int i=0;i<Operations.registrationList.Count;i++)
            {
                customer[i]=Operations.registrationList[i].CustomerID+","+Operations.registrationList[i].WalletBalance+","+Operations.registrationList[i].Name+","+Operations.registrationList[i].FatherName+","+Operations.registrationList[i].Gender+","+Operations.registrationList[i].Mobile+","+Operations.registrationList[i].DOB.ToShortDateString()+","+Operations.registrationList[i].MailID+","+Operations.registrationList[i].Location;
            }
            File.WriteAllLines("FoodDelivery/CustomerRegistration.csv",customer);


            //write content to Food details file
            string[] food=new string[Operations.foodList.Count];
            for(int i=0; i<Operations.foodList.Count;i++)
            {
                food[i]=Operations.foodList[i].FoodID+","+Operations.foodList[i].FoodName+","+Operations.foodList[i].Price;
            }
            File.WriteAllLines("FoodDelivery/FoodDetails.csv",food);

            //write content to order details list
            string[] order=new string[Operations.orderList.Count];
            for(int i=0; i<Operations.orderList.Count;i++)
            {
                order[i]=Operations.orderList[i].OrderID+","+Operations.orderList[i].BookingID+","+Operations.orderList[i].FoodId+","+Operations.orderList[i].PurchaseCount+","+Operations.orderList[i].PriceOfOrder;
            }
            File.WriteAllLines("FoodDelivery/OrderDetails.csv",order);

             //Write content to book details files
            string[] book=new string[Operations.bookingList.Count];
            for(int i=0; i<Operations.bookingList.Count; i++)
            {
                book[i]=Operations.bookingList[i].BookingID+","+Operations.bookingList[i].CustomerID+","+Operations.bookingList[i].TotalPrice+","+Operations.bookingList[i].DateOfBooking.ToShortDateString()+","+Operations.bookingList[i].Status;
            }
            File.WriteAllLines("FoodDelivery/BookingDetails.csv",book);
        }
    }
}