using System;
using System.Collections;

namespace MedicalStore
{

    public class Operations
    {
        //Object created for current user
        static UserDetails currentUser=null;
        public static List<UserDetails> userDetailsList=new List<UserDetails>();

        public static List<MedicineDetails> medicineDetailsList=new List<MedicineDetails>();

        public static List<OrderDetails> orderDetailsList=new List<OrderDetails>();

        //MainMenu Method
        public static void MainMenu()
        {
            Console.WriteLine("Online Medical Store");
            Console.WriteLine("Currently you are in Main Menu");
            string choice="yes";
            do
            {
                Console.WriteLine("Select the option 1.User Registration 2. User Login 3. Order History");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                     {
                        Console.WriteLine("User Registration"); 
                        Registration();
                        break;
                     }
                     case 2:
                     {
                        Console.WriteLine("User Login"); 
                        Login();
                        break;
                     }
                     case 3:
                     {
                        Console.WriteLine("Order History");
                        OrderHistory(); 
                        break;
                     }
                     case 4:
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
            Console.WriteLine("Enter your name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your city: ");
            string city=Console.ReadLine();
            Console.WriteLine("Enter your phone number: ");
            long phoneNumber=long.Parse(Console.ReadLine());
            Console.WriteLine("Enter your balance: ");
            int balance=int.Parse(Console.ReadLine());
            UserDetails user=new UserDetails(name,age,city,phoneNumber,balance);
            userDetailsList.Add(user);
            Console.WriteLine("Your id is:"+user.UserId);
        }

        //Login Method
        public static void Login()
        {
            System.Console.WriteLine("Enter your User Id is: ");
            string userID=Console.ReadLine();
            foreach(UserDetails data in userDetailsList)
            {
                 if(userID==data.UserId)
                 {
                     Console.WriteLine("Login Successfull");
                     currentUser=data;
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
                Console.WriteLine("Select option 1.Show Medicine list 2.Purchase medicine 3.Cancel purchase 4.Show purchase history 5.Recharge 6.Exit");
                int option=int.Parse(Console.ReadLine());
                
                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("Show Medicine List");
                        ShowMedicineList();
                        break;
                    }
                     case 2:
                    {
                        Console.WriteLine("Purchase Medicine");
                        PurchaseMedicine();
                        break;
                    }
                     case 3:
                    {
                        Console.WriteLine("Cancel Purchase");
                        CancelPurchase();
                        break;
                    }
                     case 4:
                    {
                        Console.WriteLine("Show Purchase History");
                        ShowPurchaseHistory();
                        break;
                    }
                     case 5:
                    {
                        Console.WriteLine("Recharge");
                        Recharge();
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

        ///Show Medicine list method
        public static void  ShowMedicineList()
        {
            foreach(MedicineDetails medicine in medicineDetailsList)
            {
                Console.WriteLine(medicine.MedicineId+"\t"+medicine.MedicineName+"\t"+medicine.AvailableCount+"\t"+medicine.Price+"\t"+medicine.DateOfExpiry.ToShortDateString());
            }
        }
        
        //Purchase medicine method
        public static void PurchaseMedicine()
        {

            //Show the list of medicine to user
            foreach(MedicineDetails medicine in medicineDetailsList)
            {
                Console.WriteLine(medicine.MedicineId+"\t"+medicine.MedicineName+"\t"+medicine.AvailableCount+"\t"+medicine.Price+"\t"+medicine.DateOfExpiry);
            }

            //Get the medicine Id from user
            Console.WriteLine("Enter the Medicine Id you need to buy: ");
            string medicineId=Console.ReadLine();
            
            //Get the medicine count form user
            Console.WriteLine("Enter the number of count in that medicine: ");
            int count=int.Parse(Console.ReadLine());

            foreach(MedicineDetails medicine in medicineDetailsList)
            {
                if(medicineId==medicine.MedicineId)
                {
                    if(count<=medicine.AvailableCount)
                    {
                          int Total=count*medicine.Price;
                        if(Total<=currentUser.Balance)
                        {
                            if(medicine.DateOfExpiry<=DateTime.Now)
                            {
                              
                                OrderDetails order=new OrderDetails(currentUser.UserId,medicineId,count,Total,DateTime.Now,OrderStatus.Purchased);
                                orderDetailsList.Add(order);
                                currentUser.Balance=currentUser.Balance-Total;
                                Console.WriteLine("Medicine was purchased successfully");
                                System.Console.WriteLine("Your order id is: "+order.OrderId);
                            }
                        }
                    }
                }
            }
        }

        //Cancel Purchase method
        public static void CancelPurchase()
        {
           
        
              foreach(OrderDetails order in orderDetailsList)
            {
                if(currentUser.UserId==order.UserId)
                {
                    if(order.OrderedStatus==OrderStatus.Purchased)
                    {
                         Console.WriteLine(order.OrderId+"\t"+order.UserId+"\t"+order.MedicineId+"\t"+order.TotalPrice+"\t"+order.OrderDate.ToShortDateString()+"\t"+order.OrderedStatus);
                    }
                }
            } 


            Console.WriteLine("Enter your order id:");
           string orderID=Console.ReadLine();
                  


            foreach(OrderDetails order in orderDetailsList)
            {
                if(currentUser.UserId==order.UserId)
                {
                    if(order.OrderedStatus==OrderStatus.Purchased)
                    {
                         

                  
                         foreach(MedicineDetails medicine in medicineDetailsList)
                         {
                            if(medicine.MedicineId==order.MedicineId)
                            {
                                medicine.AvailableCount=medicine.AvailableCount+order.MedicineCount;
                                currentUser.Balance=currentUser.Balance+order.TotalPrice;
                            }
                         }
                         order.OrderedStatus=OrderStatus.Cancelled;
                         Console.WriteLine("Order"+order.OrderId+"was cancelled successfully");
                    }
                }
            }

            
        }

        // purchase history method
        public static void ShowPurchaseHistory()
        {
            foreach(OrderDetails order in orderDetailsList)
            {
                if(currentUser.UserId==order.UserId)
                {
                    Console.WriteLine(order.OrderId+"\t"+order.UserId+"\t"+order.MedicineId+"\t"+order.MedicineCount+"\t"+order.TotalPrice+"\t"+order.OrderDate.ToShortDateString()+"\t"+order.OrderedStatus);
                }
            }
        }

        //Recharge method
        public static void Recharge()
        {
            Console.WriteLine("Enter the amount need to be recharged: ");
            int amount=int.Parse(Console.ReadLine());

            foreach(UserDetails user in userDetailsList)
            {
                if(currentUser.UserId==user.UserId)
                {
                    currentUser.Balance=currentUser.Balance+amount;
                }
            }
            
        }

        //Order history method
        public static void OrderHistory()
        {
            foreach(OrderDetails order in orderDetailsList)
            {
                
                Console.WriteLine(order.OrderId+"\t"+order.UserId+"\t"+order.MedicineId+"\t"+order.MedicineCount+"\t"+order.TotalPrice+"\t"+order.OrderDate+"\t"+order.OrderedStatus);
            }
        }


         //Default user details method
        public static void DefaultUserDetails()
        {
            UserDetails user1=new UserDetails("Ravi",33,"Theni",9877774440,400);
            userDetailsList.Add(user1);
            UserDetails user2=new UserDetails("Baskaran",33,"Chennai",8847757470,500);
            userDetailsList.Add(user2);
        }

        public static void DefaultMedicineDetaila()
        {
            MedicineDetails medicine1=new MedicineDetails("MD101","Paracitamol",40,5,new DateTime(2022,06,30));
            medicineDetailsList.Add(medicine1);
            MedicineDetails medicine2=new MedicineDetails("MD102","Calpol",10,5,new DateTime(2022,05,30));
            medicineDetailsList.Add(medicine2);
            MedicineDetails medicine3=new MedicineDetails("MD103","Gelucil",3,40,new DateTime(2022,04,30));
            medicineDetailsList.Add(medicine3);
            MedicineDetails medicine4=new MedicineDetails("MD104","Metrogel",5,50,new DateTime(2022,10,30));
            medicineDetailsList.Add(medicine4);
            MedicineDetails medicine5=new MedicineDetails("MD105","Povidin Iodin",10,50,new DateTime(2022,10,30));
            medicineDetailsList.Add(medicine5);
        }

        public static void DefaultOrderDetails()
        {
           OrderDetails order1=new OrderDetails("UID1001","MID101",3,15,new DateTime(2022,05,13),OrderStatus.Purchased);
            orderDetailsList.Add(order1);
            OrderDetails order2=new OrderDetails("UID1002","MID102",2,10,new DateTime(2022,05,13),OrderStatus.Cancelled);
            orderDetailsList.Add(order2);
            OrderDetails order3=new OrderDetails("UID1003","MID103",2,100,new DateTime(2022,05,13),OrderStatus.Purchased);
            orderDetailsList.Add(order3);
            OrderDetails order4=new OrderDetails("UID1004","MID104",3,120,new DateTime(2022,05,15),OrderStatus.Cancelled);
            orderDetailsList.Add(order4);
             OrderDetails order5=new OrderDetails("UID1005","MID105",5,250,new DateTime(2022,05,15),OrderStatus.Purchased);
            orderDetailsList.Add(order5);
             OrderDetails order6=new OrderDetails("UID1006","MID106",3,15,new DateTime(2022,05,15),OrderStatus.Purchased);
            orderDetailsList.Add(order6);
        }

    }
}