using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Ecommerce
{
    public class Files
    {

        public static void Create()
        {
       if(!Directory.Exists("EcommerceDetails"))    //Folder Creation
       {
        Console.WriteLine("Creating Folder");
        Directory.CreateDirectory("EcommerceDetails");
       }

        if(!Directory.Exists("EcommerceDetails/CustomerDetails.csv"))
        {
          Console.WriteLine("Creating Files");
          File.Create("EcommerceDetails/CustomerDetails.csv");
        }

        if(!Directory.Exists("EcommerceDetails/OrderDetails.csv"))
        {
          Console.WriteLine("Creating Files");
          File.Create("EcommerceDetails/OrderDetails.csv");
        }

        if(!Directory.Exists("EcommerceDetails/ProductDetails.csv"))
        {
          Console.WriteLine("Creating Files");
          File.Create("EcommerceDetails/ProductDetails.csv");
        }
        
       } 


       public static void ReadFile()
       {
        string[] customer=File.ReadAllLines("EcommerceDetails/CustomerDetails.csv");
        foreach(string data in customer)
        {
            CustomerDetails customer1=new CustomerDetails(data);
            Operations.CustomerDetailsList.Add(customer1);
        }
       

        string[] order=File.ReadAllLines("EcommerceDetails/OrderDetails.csv");
        foreach(string data1 in order)
        {
            OrderDetails order1=new OrderDetails(data1);
            Operations.OrderDetailsList.Add(order1);
        }

        string[] product=File.ReadAllLines("EcommerceDetails/ProductDetails.csv");
        foreach(string data2 in product)
        {
            ProductDetails product1=new ProductDetails(data2);
            Operations.ProductDetailsList.Add(product1);
        }

       }

       public static void WriteToFiles()
       {
        string[] customer=new string[Operations.CustomerDetailsList.Count];
        for(int i=0;i<Operations.CustomerDetailsList.Count; i++)
        {
            customer[i]=Operations.CustomerDetailsList[i].CustomerId+","+Operations.CustomerDetailsList[i].Name+","+Operations.CustomerDetailsList[i].City+","+Operations.CustomerDetailsList[i].MobileNumber+","+Operations.CustomerDetailsList[i].WalletBalance+","+Operations.CustomerDetailsList[i].EmailId;
        }
        File.WriteAllLines("EcommerceDetails/CustomerDetails.csv",customer);


        string[] order=new string[Operations.OrderDetailsList.Count];
        for(int i=0;i<Operations.OrderDetailsList.Count; i++)
        {
            order[i]=Operations.OrderDetailsList[i].OrderId+","+Operations.OrderDetailsList[i].CustomerId+","+Operations.OrderDetailsList[i].ProductId+","+Operations.OrderDetailsList[i].TotalPrice+","+Operations.OrderDetailsList[i].PurchaseDate+","+Operations.OrderDetailsList[i].Quantity+","+Operations.OrderDetailsList[i].OrderStatus;
        }
        File.WriteAllLines("EcommerceDetails/OrderDetails.csv",order);

        
        string[] product=new string[Operations.ProductDetailsList.Count];
        for(int i=0;i<Operations.ProductDetailsList.Count; i++)
        {
            order[i]=Operations.ProductDetailsList[i].ProductId+","+Operations.ProductDetailsList[i].ProductName+","+Operations.ProductDetailsList[i].Stock+","+Operations.ProductDetailsList[i].ShippingDuration;
        }
        File.WriteAllLines("EcommerceDetails/OrderDetails.csv",order);
       }



    }
}