using System;


namespace OnlineGroceryStoreApplication;

public delegate void EventManager(); 

class Operations
{

    public static event EventManager eventLink=null;

    public static void  Subscribe()
    {
        eventLink+= new EventManager(Files.Create);
        eventLink+= new EventManager(Files.ReadFile);
        eventLink+= new EventManager(Operations.MainMenu);
        eventLink+= new EventManager(Files.WriteToFiles);
    }

    public static void StartEvent()
    {
        Subscribe();
        eventLink();
    }
    static CustomerRegistration currentLoggedInCustomer=null;                          //Object creation
    public static List<CustomerRegistration> customerList=new List<CustomerRegistration>();   //Customer List

    public static List<ProductDetails> productList=new List<ProductDetails>();                 //Product List

    public static List<BookingDetails> bookingList=new List<BookingDetails>();                 //Booking List
  
    public static List<OrderDetails> orderList=new List<OrderDetails>();                       //Order List


    public static void MainMenu()
    {

       

        Console.WriteLine("Now you are currently in main menu");
        string choice="yes";
        do
        {
          
          
        Console.WriteLine("Select any option"+"\n"+" 1.Customer Registration"+"\n"+" 2.Customer Login"+"\n"+" 3.Exit");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                Console.WriteLine("You are currently in Customer Registration");
                CustomerRegistration();     //call the customer registration method
                break;
            }
            case 2:
            {
                Console.WriteLine("You are currently in Customer Login");
                CustomerLogin();           //call the login method
                break;
            }
            case 3:
            {
                Console.WriteLine("Currently you have selected Exit Option");
                Console.WriteLine("Exiting MainMenu");
                choice="no";
                break;
            }
        }
        
          
        }while(choice=="yes");
   }

    public static void CustomerRegistration()
    {
        Console.WriteLine("Customer Registration method called");
        Console.Write("Enter your Name:");
        string name=Console.ReadLine();
        Console.Write("Enter your Father Name:");
        string fatherName=Console.ReadLine();
        Console.Write("Enter your Gender: ");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        Console.Write("Enter your Mobile Number:");
        long mobileNumber=long.Parse(Console.ReadLine());
        Console.Write("Enter your Date Of Birth: ");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        Console.Write("Enter your mail id: ");
        string mailID=Console.ReadLine();
        System.Console.Write("Enter your wallet balance:");
        double walletBalance=double.Parse(Console.ReadLine());
        CustomerRegistration customer=new CustomerRegistration(name,fatherName,gender,mobileNumber,dob,mailID);    //creating the object
        customerList.Add(customer);   //Add object to list
        Console.WriteLine("Your CustomerId is: "+customer.CustomerId);
        
        
    }

    public static void CustomerLogin()
    {
        Console.WriteLine("Customer Login method called");

        //Get the customerID from user
        Console.WriteLine("Enter your Customer Id: ");
        string customerID=Console.ReadLine().ToUpper();

        int temp=0;
         foreach(CustomerRegistration customerdata in customerList)
         {
           if(customerdata.CustomerId==customerID)
           {
                Console.WriteLine("You have enter valid customerID");
                currentLoggedInCustomer=customerdata;
                Console.WriteLine("Login Successfull");
                SubMenu();
                temp=1;
           }
         }
         if(temp==0)
         {
            Console.WriteLine("Invalid  customerID");
         }
         
        
    }

    //SUBMENU
    public static void SubMenu()
    {
        string choice="yes";
        do
        {

            
        Console.WriteLine("Select option"+"\n"+" 1.Show Customer Details"+"\n"+" 2.Show product details"+"\n"+" 3.Wallet Recharge"+"\n"+" 4.Take Order"+"\n"+" 5.Modify order quantity"+"\n"+" 6.Cancel order"+"\n"+" 7.Exit");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                Console.WriteLine("Currently you are in Show Customer Details");
                currentLoggedInCustomer.ShowCustomerDetails();
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Currently you are in Show Product details");
                ProductDetails();
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Currently you are in Wallet Recharge");
                currentLoggedInCustomer.WalletRecharge();
                break;
            }
            case 4:
            {
                System.Console.WriteLine("Currently you are in Take order");
                TakeOrder();
                break;
            }
            case 5:
            {
                Console.WriteLine("Currently you are in Modify order quantity");
                ModifyOrderQuantity();
                break;
            }
            case 6:
            {
                System.Console.WriteLine("Currently you are in Cancel page");
                CancelOrder();
                break;
            }
            case 7:
            {
                System.Console.WriteLine("Currently you have selected exit option");
                choice="no";
                break;
            }
            
        }
            

        }while(choice=="yes");
    }

    //Show Product Details
    public static void ProductDetails()
    {
        foreach(ProductDetails products in productList)
        {
           products.ShowProductDetails();
        }
    }

    //Show Take Order data
    public static void TakeOrder()
    {

        //Creat a booking object
        BookingDetails bookingData=new BookingDetails(currentLoggedInCustomer.CustomerId,0,DateTime.Now,BookingStatus.Initiated);

        //creating tempOrderList
        List<OrderDetails> tempOrderList=new List<OrderDetails>();

        //Global variable creation
        double totalAmount=0;

         //do loop
        string choice="yes";
        do
        {
           
       
          //Show the product details
          ProductDetails();

          //Select the product & check for the product
          Console.WriteLine("Select the product form the above list by using productID:");
          string productId=Console.ReadLine().ToUpper();

          foreach(ProductDetails products in productList)
           {
             if(products.ProductId==productId)
              {
               //Get quantity & compare with availabilty
               Console.WriteLine("Enter the number of product quantity need to buy");
               int quantity=int.Parse(Console.ReadLine());

                  if(quantity<=products.QuantityAvailable)
                   {
                      //calculate price and compare with customer wallet
                      double price=quantity*products.PricePerQuantity;

                      //Take order  & create object & add local order list
                      OrderDetails order=new OrderDetails(bookingData.BookingId,productId,quantity,price);
                      tempOrderList.Add(order);
                      products.QuantityAvailable-=quantity;
                      Console.WriteLine("This product is added to your cart");
                   }
                //   else
                //    {
                //     Console.WriteLine("Product quantity is not available");
                //    }
               }
            //   else
            //   {
            //      Console.WriteLine("You have choosen wrong product id");
            //   }
            }

            Console.Write("Do you want to add another product in cart:");
            choice=Console.ReadLine();

            
            

        }while(choice=="yes");
        
        
        foreach(OrderDetails orders in tempOrderList)
        {
            totalAmount+=orders.PriceOfOrder; 
        }

        Console.WriteLine("Do you want to purchase the order:");
        string purchase=Console.ReadLine().ToLower();
        if(purchase=="yes")
        {
            bool proceed=true;
            while(proceed)
            {
                if(totalAmount<=currentLoggedInCustomer.WalletBalance)
                {
                    currentLoggedInCustomer.WalletBalance-=totalAmount;
                    bookingData.Status=BookingStatus.Booked;
                    bookingData.TotalPrice=totalAmount;
                    bookingList.Add(bookingData);
                    orderList.AddRange(tempOrderList);
                    Console.WriteLine("Booked Successfully. Your BookedId is: "+bookingData.BookingId);
                    proceed=false;
                }
                else
                {
                    double remainingAmount=totalAmount-currentLoggedInCustomer.WalletBalance;
                    Console.WriteLine("your order amount is "+totalAmount+"and your wallet balance is"+currentLoggedInCustomer.WalletBalance+"Still you need to recharge"+remainingAmount);
                    currentLoggedInCustomer.WalletRecharge();
                }
            }

        }
        else
        {
            foreach(ProductDetails products in productList)
            {
                foreach(OrderDetails orders in orderList)
                {
                    if(products.ProductId==orders.OrderId)
                    {
                        products.QuantityAvailable+=orders.PurchaseCount;
                        orders.PurchaseCount=0;
                        orders.PriceOfOrder=0;
                        bookingData.Status=BookingStatus.Cancelled;
                        bookingList.Add(bookingData);
                    }
                }
                
            }
        }




     
       
}





    //Modify Order Quantity
    public static void ModifyOrderQuantity()
    {
       Console.WriteLine("You are in modify order quantity"); 
    }


    //Cancel order method
    public static void CancelOrder()
    {
      Console.WriteLine("You are in cancel order");  
    }



    //Default data
    public static void DefaultData()
    {
        
        //Customer Details Data
        CustomerRegistration customer=new CustomerRegistration("Ravi","Ettapparajan",Gender.Male,974774646,new DateTime(1999,11,11),"ravi@gmail.com");
        customerList.Add(customer);
        CustomerRegistration customer1=new CustomerRegistration("Baskaran","Sethurajan",Gender.Male,847575775,new DateTime(1999,11,11),"baskaran@gmail.com");
        customerList.Add(customer1);

        //Product Details Data
          ProductDetails product=new ProductDetails("Sugar",20,40);
          productList.Add(product);
          ProductDetails product1=new ProductDetails("Rice",100,50);
          productList.Add(product1);
          ProductDetails product2=new ProductDetails("Milk",10,40);
          productList.Add(product2);
          ProductDetails product3=new ProductDetails("Coffee",20,40);
          productList.Add(product3);
          ProductDetails product4=new ProductDetails("Tea",10,10);
          productList.Add(product4);
          ProductDetails product5=new ProductDetails("Masala Powder",10,20);
          productList.Add(product5);
          ProductDetails product6=new ProductDetails("Salt",10,10);
          productList.Add(product6);
          ProductDetails product7=new ProductDetails("Turmeric Powder",20,40);
          productList.Add(product7);
          ProductDetails product8=new ProductDetails("chilli Powder",10,20);
          productList.Add(product8);
          ProductDetails product9=new ProductDetails("Groundnut oil",10,20);
          productList.Add(product9);
        

            //Order Details data
            OrderDetails order=new OrderDetails("BID3001","PID101",2,80);
            orderList.Add(order);
            OrderDetails order1=new OrderDetails("BID3001","PID102",2,100);
            orderList.Add(order1);
            OrderDetails order2=new OrderDetails("BID3001","PID103",1,40);
            orderList.Add(order2);
            OrderDetails order3=new OrderDetails("BID3002","PID101",1,40);
            orderList.Add(order3);
            OrderDetails order4=new OrderDetails("BID3002","PID102",4,200);
            orderList.Add(order4);
            OrderDetails order5=new OrderDetails("BID3002","PID110",1,140);
            orderList.Add(order5);
            OrderDetails order6=new OrderDetails("BID3002","PID109",1,20);
            orderList.Add(order6);
            OrderDetails order7=new OrderDetails("BID3003","PID102",2,100);
            orderList.Add(order7);
            OrderDetails order8=new OrderDetails("BID3003","PID108",4,100);
            orderList.Add(order8);
            OrderDetails order9=new OrderDetails("BID3003","PID101",2,80);
            orderList.Add(order9);
        

        //Booking Details data
          BookingDetails booking=new BookingDetails("CID3001",220,new DateTime(2022,07,26),BookingStatus.Booked);
          bookingList.Add(booking);
          BookingDetails booking1=new BookingDetails("CID3002",400,new DateTime(2022,07,26),BookingStatus.Booked);
          bookingList.Add(booking1);
          BookingDetails booking2=new BookingDetails("CID3001",220,new DateTime(2022,07,26),BookingStatus.Cancelled);
          bookingList.Add(booking2);
          BookingDetails booking3=new BookingDetails("CID3002",0,new DateTime(2022,07,26),BookingStatus.Initiated);
          bookingList.Add(booking3);
    }
}