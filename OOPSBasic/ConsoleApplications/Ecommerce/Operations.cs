using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce
{
   
    public class Operations
    {

        static CustomerDetails currentCustomer=null;  //Object created to store current customer
        public static List<CustomerDetails> CustomerDetailsList=new List<CustomerDetails>(); //Customer list creation

        public static List<ProductDetails> ProductDetailsList=new List<ProductDetails>();  //Product List creation.

        public static List<OrderDetails> OrderDetailsList=new List<OrderDetails>();  //Order List Creation.

        //MainMenu Creation
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
            Console.WriteLine("Select Options 1.Customer Registration 2.Login and Purchase 3.Exit");
            int option=int.Parse(Console.ReadLine());

            switch(option)
            {
               case 1:
               {
                  Console.WriteLine("Customer Registration");
                  Registration();
                  break;
               }

                case 2:
               {
                  Console.WriteLine("Login and Purchase");
                  Login();
                  break;
               }
               case 3:
               {
                 Console.WriteLine("Exit");
                 choice="no";
                 break;
               }

            }
        }while(choice=="yes");
            
    }

        //Registration Method

        public static void Registration()
        {
            Console.Write("Enter your Name:");
            string name=Console.ReadLine();
            Console.Write("Enter your City:");
            string city=Console.ReadLine();
            Console.Write("Enter your PhoneNumber:");
            long mobileNumber=long.Parse(Console.ReadLine());
            Console.Write("Enter your EmailId:");
            string emailId=Console.ReadLine();
            Console.Write("Enter your Wallet Initial Balance:");
            int walletBalance=int.Parse(Console.ReadLine());
            CustomerDetails customer3=new CustomerDetails(name,city,mobileNumber,walletBalance,emailId); //Object creation
            CustomerDetailsList.Add(customer3); //Add object to list
            Console.WriteLine("Your customerId is:"+customer3.CustomerId);
          
        }

        //Login and Pruchse method
        public static void Login()
        {
           Console.WriteLine("Enter your CustomerId:");
           string customerID=Console.ReadLine();
           foreach(CustomerDetails customer in CustomerDetailsList)
           {
              if(customer.CustomerId==customerID)
              {
                 Console.WriteLine("Login Successfully");
                 currentCustomer=customer;
                 SubMenu();
              }
              
           }
          

           
        }

       //SubMenu Method
       public static void SubMenu()
       {
        string choice="yes";
        do
        {
            Console.WriteLine("Select the options 1.Purchase 2.Order History 3.Cancel Order 4.WlletBalance 5.Exit");
            int option=int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                {
                    Console.WriteLine("Purchase");
                    Purchase();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Order History");
                    OrderHistory();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Cancel Order");
                    CancelOrder();
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Wallet Balance");
                    WalletBalance();
                    break;
                }
                case 5:
                {
                    Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
            

        }while(choice=="yes");
       }

       //Purchase Method
       public static void Purchase()
       {

          //show list of product
          foreach(ProductDetails product in ProductDetailsList)
          {
              Console.WriteLine(product.ProductId +"\t"+ product.ProductName +"\t"+ product.Stock +"\t"+ product.Price +"\t"+ product.ShippingDuration);
          }

          //Ask customer to select product id
          Console.WriteLine("Select any product Id:");
          string productID=Console.ReadLine();
          

          //Ask for count to purchase
          Console.WriteLine("Enter the stock count:");
          int count=int.Parse(Console.ReadLine());
          

         foreach(ProductDetails product1 in ProductDetailsList)
         {
            if(productID==product1.ProductId)
            {
                if(count<=product1.Stock)
                {
                    int deliveryCharge=500;
                    int totalAmount=(count*product1.Price)+deliveryCharge;

                    if(currentCustomer.WalletBalance>=totalAmount)
                    {

                    foreach(CustomerDetails customer1 in CustomerDetailsList)
                    {
                        if(currentCustomer.CustomerId==customer1.CustomerId)
                        {
                            currentCustomer.WalletBalance=currentCustomer.WalletBalance-totalAmount;

                        }
                    }    
                        product1.Stock--;
                        Console.WriteLine("Order Conformed");
                        OrderDetails order1=new OrderDetails(currentCustomer.CustomerId,product1.ProductId,totalAmount,DateTime.Now, count,OrderStatus.Ordered);
                        if(order1.ProductId==product1.ProductId)
                        {
                             Console.WriteLine("Order placed successfully");
                             DateTime date1=order1.PurchaseDate.AddDays(product1.ShippingDuration);
                             Console.WriteLine("Your order will be delivery on"+date1.ToShortDateString());
                             OrderDetailsList.Add(order1);
                             Console.WriteLine("Your order id is:"+order1.OrderId);
                        }
                    }
                  
                 else
                {
                    Console.WriteLine("Insufficient Wallet Balance. Please recharge your wallet");
                }
                }
                else
                {
                    Console.WriteLine("Required count is not available");
                }
            }
         }
     

    }

        //Order history method
        public static void OrderHistory()
        {
            foreach(OrderDetails order2 in OrderDetailsList)
            {
                if(currentCustomer.CustomerId==order2.CustomerId)
                {
                    Console.WriteLine(order2.CustomerId +"\t"+ order2.ProductId+"\t"+order2.OrderId+"\t"+order2.PurchaseDate+"\t"+order2.Quantity+"\t"+order2.TotalPrice+"\t"+order2.OrderStatus);
                }
            }
        }
      
       //Cancel Order method
       public static void CancelOrder()
       {
        foreach(OrderDetails order2 in OrderDetailsList)
        {
            if(currentCustomer.CustomerId==order2.CustomerId)
            {
                Console.WriteLine(order2.CustomerId +"\t"+ order2.ProductId+"\t"+order2.OrderId+"\t"+order2.PurchaseDate+"\t"+order2.Quantity+"\t"+order2.TotalPrice+"\t"+order2.OrderStatus);
            }
        }
       
       Console.WriteLine("Enter the ordered Id:");
       string orderID=Console.ReadLine();
       
       foreach(OrderDetails order3 in OrderDetailsList)
       {
        if(order3.CustomerId==currentCustomer.CustomerId)
        {
            foreach(ProductDetails product1 in ProductDetailsList)
            {
            if(order3.ProductId==product1.ProductId)
            {
               product1.Stock=order3.Quantity;
               foreach(CustomerDetails customer in CustomerDetailsList)
               {
                if(currentCustomer.CustomerId==customer.CustomerId)
                {
                    customer.WalletBalance=customer.WalletBalance+order3.TotalPrice;
                }
               }
               order3.OrderStatus=OrderStatus.Cancelled;
               Console.WriteLine("Your order is cancelled");
        }
       }
       }
       }
       }


       //Wallet Balance method
       public static void WalletBalance()
       {
        
            Console.WriteLine("Your wallet balance is:"+currentCustomer.WalletBalance);
            Console.WriteLine("Whether you need to recharge:");
            string recharge=Console.ReadLine();
            
            if(recharge=="yes")
            {
                Console.WriteLine("Enter the amount to be recharged:");
                int amount=int.Parse(Console.ReadLine());
                currentCustomer.WalletBalance=currentCustomer.WalletBalance+amount;
                Console.WriteLine("Your Wallet Ballence is:"+currentCustomer.WalletBalance);
                
            }
            else
            {
                SubMenu();
            }
        }
       

        //Default method for customer details
        public static void DefaultCustomerDetails()
        {
            CustomerDetails customer1=new CustomerDetails("Ravi","Chennai",9885858588,50000,"ravi@mail.com");
            CustomerDetailsList.Add(customer1);
            CustomerDetails customer2=new CustomerDetails("Baskaran","Chennai",988475757,60000,"baskaran@mail.com");
            CustomerDetailsList.Add(customer2);
        }


        //Default method for product details

        public static void DefaultProductDetails()
        {
            ProductDetails product1=new ProductDetails("Mobile",10,10000,2);
            ProductDetailsList.Add(product1);
            ProductDetails product2=new ProductDetails("Tablet",5,15000,2);
            ProductDetailsList.Add(product2);
            ProductDetails product3=new ProductDetails("Camera",3,20000,4);
            ProductDetailsList.Add(product3);
            ProductDetails product4=new ProductDetails("iPhone",5,50000,6);
            ProductDetailsList.Add(product4);
            ProductDetails product5=new ProductDetails("Laptop",3,40000,3);
            ProductDetailsList.Add(product5);
        }

        //Default method for order details

        public static void DefaultOrderDetails()
        {
            OrderDetails order1=new OrderDetails("CID1001","PID101",20000,DateTime.Now,2,OrderStatus.Ordered);
            OrderDetailsList.Add(order1);
            OrderDetails order2=new OrderDetails("CID1002","PID103",40000,DateTime.Now,2,OrderStatus.Ordered);
            OrderDetailsList.Add(order2);
        }
    }
}