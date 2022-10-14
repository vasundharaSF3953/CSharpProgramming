using System;
using System.Collections;

namespace FoodDeliveryApplication
{
    public delegate void EventManager();   // create delegate
    public class Operations
    {

        public static event EventManager eventlink=null;     //create event


        public static void Subscribe()     //create method
        {
            eventlink +=new EventManager(Files.Create);
            eventlink +=new EventManager(Files.ReadFile);
            eventlink +=new EventManager(Operations.MainMenu);
            eventlink +=new EventManager(Files.WriteToFiles);

        }

        public static void StartEvent()
        {
            Subscribe();
            eventlink();
        }
         public static CustomerRegistration currentCustomer=null; 
        public static List<CustomerRegistration> registrationList=new List<CustomerRegistration>();   

        public static List<FoodDetails> foodList=new List<FoodDetails>();

        public static List<BookingDetails> bookingList=new List<BookingDetails>();

        public static List<OrderDetails> orderList=new List<OrderDetails>();


        //mainmenu method
        public static void MainMenu()
        {
            string choice="yes";
  
            do
            {
                Console.WriteLine("Select option"+"\n"+"1.Customer Registration"+"\n"+"2.Customer Login"+"\n"+"3.Exit");
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
                        Console.WriteLine("Customer Login");
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

        public static void Registration()
        {
             Console.Write("Enter your Name: ");
             String name=Console.ReadLine();
             Console.Write("Enter your FatherName: ");
             String fatherName=Console.ReadLine();
             Console.Write("Enter your Gender: ");
             String gender=Console.ReadLine();
             Console.Write("Enter your Mobile Number: ");
             long mobile=long.Parse(Console.ReadLine());
             Console.Write("Enter your Date Of Birth: ");
             DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
             Console.Write("Enter your mailId: ");
             String mailId=Console.ReadLine();
             Console.Write("Enter your Location: ");
             String location=Console.ReadLine();
             Console.Write("Enter your Wallet Balance: ");
             int walletBalance=int.Parse(Console.ReadLine());
             CustomerRegistration customer1=new CustomerRegistration(name,fatherName,gender,mobile,dob,mailId,location,walletBalance);
             registrationList.Add(customer1);
             Console.WriteLine("Your Customer ID: "+customer1.CustomerID);
        }

        //Login method
        public static void Login()
        {
            Console.Write("Enter your Customer id:");
            string customerId=Console.ReadLine().ToUpper();
            
            foreach(CustomerRegistration customer in registrationList)
            {
                 if(customer.CustomerID==customerId)
                 {
                    Console.WriteLine("Login Sucessfully");
                    currentCustomer=customer;
                    SubMenu();
                 }
                 
            }


        }


        //SubMenu method
        public static void SubMenu()
        {
            string choice="yes";
            do
            {
                Console.WriteLine("Select option"+"\n"+"1.Show Food item Details"+"\n"+"2.Order Food"+"\n"+"3.Cancel Booking"+"\n"+"4.Order History"+"\n"+"5.Recharge Wallet"+"\n"+"6.Exit");
                int option=int.Parse(Console.ReadLine());
                
                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("Show Food item Details ");
                        ShowFoodItem();
                        break;
                    }
                     case 2:
                    {
                        Console.WriteLine("Order Food");
                        OrderFood();
                        break;
                    }
                    //  case 3:
                    // {
                    //     Console.WriteLine("Cancel Order");
                    //     CancelOrder();
                    //     break;
                    // }
                     case 3:
                    {
                        Console.WriteLine("Cancel Booking");
                        CancelBooking();
                        break;
                    }
                     case 4:
                    {
                        Console.WriteLine("Order History");
                        orderHistory();
                        break;
                    }
                     case 5:
                    {
                        Console.WriteLine("Recharge Wallet");
                        RechargeWallet();
                        break;
                    }
                     case 6:
                    {
                        Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }

            }while(choice=="yes");
        }


        //Food item method
        public static void ShowFoodItem()
        {
            foreach(FoodDetails food in foodList)
            {
                Console.WriteLine(food.FoodID+"\t"+food.FoodName+"\t"+food.Price);
            }
        }

        //Order food method()
        public static void OrderFood()
        {
            List<BookingDetails> booking=new List<BookingDetails>();
            //Ask user
            Console.Write("Do you want to purchase: ");
            string choice=Console.ReadLine().ToLower();

             //create object for booking details
                BookingDetails booking1=new BookingDetails(currentCustomer.CustomerID,0,DateTime.Now,BookingStatus.Initiated);
                //booking.Add(booking1);


            while(choice=="yes")
            {
               

                //Show the food items
                foreach(FoodDetails food in foodList)
                {
                   Console.WriteLine(food.FoodID+"\t"+food.FoodName+"\t"+food.Price);
                }

                //Get Food id and quantity from user
                Console.Write("Select any food id: ");
                string foodID=Console.ReadLine().ToUpper();
                Console.Write("Enter the number of quantity need to buy: ");
                int quantity=int.Parse(Console.ReadLine());
                
                //Check food id available
                foreach(FoodDetails food1 in foodList)
                {
                    if(food1.FoodID==foodID)
                    {
                        int currentOrder=food1.Price*quantity;

                        //check wallet balance
                       
                            if(currentOrder<=currentCustomer.WalletBalance)
                            {
                                OrderDetails order1=new OrderDetails(booking1.BookingID,foodID,quantity,currentOrder);
                                orderList.Add(order1);
                                currentCustomer.WalletBalance -=currentOrder;
                            }
                        

                    }
                }

                Console.Write("Doy you want to order more: ");
                choice=Console.ReadLine().ToLower();

                if(choice=="no")
                {
                    foreach(OrderDetails order in orderList)
                    {
                        if(currentCustomer.CustomerID==booking1.CustomerID)
                        {
                        if(order.BookingID==booking1.BookingID)
                        {
                            booking1.TotalPrice +=order.PriceOfOrder;
                        }
                        }
                    }
                        booking1.Status=BookingStatus.Booked;
                        booking.Add(booking1);
                        bookingList.AddRange(booking);
                        Console.WriteLine("Booking Successful and Booking ID: "+booking1.BookingID);
                }
            }
            
        }

        //Cancel order method
        // public static void CancelOrder()
        // {

        //     foreach(BookingDetails booking in bookingList)
        //     {

        //          if(booking.CustomerID==currentCustomer.CustomerID)
        //          {
        //             if(booking.Status==BookingStatus.Booked)
        //             {
        //                 foreach(OrderDetails order in orderList)
        //                 {
        //                     if(order.BookingID==booking.BookingID)
        //                     {
        //                         Console.WriteLine(order.OrderID+"\t"+order.BookingID+"\t"+order.FoodId+"\t"+order.PurchaseCount+"\t"+order.PriceOfOrder);

                                 
                                
        //                     }
        //                 }
        //                 Console.WriteLine("Pick any order Id: ");
        //                 string orderid=Console.ReadLine();
                        
        //                   foreach(OrderDetails order2 in orderList)
        //                   {
        //                      if(order2.OrderID==orderid)
        //                     {
        //                         currentCustomer.WalletBalance +=order2.PriceOfOrder;
        //                         order2.PurchaseCount=0;
        //                         order2.PriceOfOrder=0;
        //                         bookingList.Add(booking);
        //                     }
        //                 }
        //          }
        //     }
        //     }
        // }

        //Cancel Booking
        public static void CancelBooking()
        {

             foreach(BookingDetails booking in bookingList)
            {
                 if(booking.CustomerID==currentCustomer.CustomerID)
                 {
                    if(booking.Status==BookingStatus.Booked)
                    {
                        Console.WriteLine(booking.BookingID+"\t"+booking.CustomerID+"\t"+booking.TotalPrice+"\t"+booking.DateOfBooking.ToShortDateString());
                    }
                 }
            }
              
            Console.Write("Select the booking id: ");
            string bookingID1=Console.ReadLine().ToUpper();

               foreach(BookingDetails booking in bookingList)
            {
                 if(booking.CustomerID==currentCustomer.CustomerID)
                 {
                    if(booking.Status==BookingStatus.Booked && bookingID1==booking.BookingID)
                    {
                       booking.Status=BookingStatus.Cancelled;
                        currentCustomer.WalletBalance+=booking.TotalPrice;
                        Console.WriteLine("Booking canceled successfully");
                        booking.TotalPrice=0;
                        booking.DateOfBooking=DateTime.Now;
                        // foreach(OrderDetails order2 in orderList)
                        //   {
                        //      if(order2.BookingID==booking.BookingID)
                        //     {
                        //        order2.PriceOfOrder=0;
                        //     }
                        //   }

                    }
                 }
               
                                
            }

        }

        //order history method
        public static void orderHistory()
        {
            foreach(BookingDetails booking1 in bookingList)
            {
                if(currentCustomer.CustomerID==booking1.CustomerID)
                {
                    Console.WriteLine(booking1.BookingID+"\t"+booking1.CustomerID+"\t"+booking1.TotalPrice+"\t"+booking1.DateOfBooking.ToShortDateString());
                }
            }
        }

        
        public static void RechargeWallet()
        {
            currentCustomer.WalletRecharge();
        }
    }
}