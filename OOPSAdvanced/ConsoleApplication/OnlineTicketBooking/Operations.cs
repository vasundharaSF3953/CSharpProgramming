using System;

//User defined delegates
public delegate void EventManager();       

namespace OnlineTicketBooking
{
    public class Operations
    {
            //user defined events
            public static event EventManager eventLink=null;

             //Subscrible method
            public static void Subscribe()
            {
                eventLink += new EventManager(Files.Create);
                eventLink += new EventManager(Files.ReadFile);
                eventLink += new EventManager(Operations.MainMenu);
                eventLink += new EventManager(Files.WriteToFiles);
            }

             //Start event method
            public static void StartEvent()
            {
                Subscribe();
                eventLink();
            }


             //object creation
            static UserDetails currentLoggedInUser=null;

            //User list creation
            public static List<UserDetails> userList=new List<UserDetails>();   


            //Booking list creation
            public static List<BookingDetails> bookingList=new List<BookingDetails>();      

            //Theatre list creation
            public static List<TheaterDetails> theaterList=new List<TheaterDetails>();      

            //Movie list creation
            public static List<MovieDetails> movieList=new List<MovieDetails>();             

            //Screening list creation
            public static  List<ScreeningDetails> screeningList=new List<ScreeningDetails>();   
        

            //Main Method
            public static void MainMenu()
            {
                Console.WriteLine("Currently you are in MainMenu");
                //initialize the choice as yes
                string choice="yes";
                do
                {
                    Console.WriteLine("Select the following option"+"\n"+"1. User Registration"+"\n"+"2.Login"+"\n"+"3.Exit");
                    int option=int.Parse(Console.ReadLine());

                    switch(option)
                    {
                        case 1:
                        {
                            Console.WriteLine("You have choosen User Registration menu");
                            Registration();
                            break;
                        }
                        case 2:
                        {
                            Console.WriteLine("You have choosen User Login menu");
                            Login();
                            break;
                        }
                        case 3:
                        {
                            Console.WriteLine("You have choosen the exit menu");
                            Console.WriteLine("Exicted from main menu");
                            choice="no";
                            break;
                        }
                    }
                    

                }while(choice=="yes");
            }


            public static void Registration()
            {
                 Console.WriteLine("Now you have to Enter your personal Details");

                 //Get name form user
                 System.Console.Write("Enter your Name: ");
                 string name=Console.ReadLine();

                 //Get user age
                 System.Console.Write("Enter your Age: ");
                 int age=int.Parse(Console.ReadLine());

                 //Get phone number form user
                 System.Console.Write("Enter your Phone Number: ");
                 long phoneNumber=long.Parse(Console.ReadLine());

                 //Get wallet balance from user
                 System.Console.Write("Enter your WalletBalance: ");
                 double walletBalance=double.Parse(Console.ReadLine());

                 //Creating object for user details
                 UserDetails userData=new UserDetails(name,age,phoneNumber,walletBalance);

                 //Add object to list
                 userList.Add(userData);

                 //Display user id to current user
                 System.Console.WriteLine("Your UserId is: "+userData.UserId);
            }


            //Login method creation
            public static void Login()
            {
                //Get the user id from user
                Console.Write("Enter your userId:");
                string currentUserID=Console.ReadLine().ToUpper();

                //Checking the current user is already available or not
                int temp=0;
                foreach(UserDetails users in userList)
                {
                    if(users.UserId==currentUserID)
                    {
                        Console.WriteLine("You have entered the valid userId");
                        currentLoggedInUser=users;
                        SubMenu();     //Calling Sub menu function
                        temp=1;

                    }
                }

                if(temp==0)
                {
                    Console.WriteLine("Invalid UserId");
                }
                

            }
            

            //SubMenu creation
            public static void SubMenu()
            {
                string choice="yes";
                do
                {
                    //Show the list of submenus to user
                    Console.WriteLine("Select any one option shown below"+"\n"+"a.Ticket Booking"+"\n"+"b.Ticket Cancellation"+"\n"+"c.Booking History"+"\n"+"d.Wallet Recharge"+"\n"+"e.Exit");
                    char option=char.Parse(Console.ReadLine());

                    switch(option)
                    {
                        case 'a':
                        {
                            Console.WriteLine("You have selected ticket booking menu");
                            TicketBooking();
                            break;
                        }
                        case 'b':
                        {
                            Console.WriteLine("You have selected ticket cancellation menu menu");
                            TicketCancellation();
                            break;
                        }
                        case 'c':
                        {
                            Console.WriteLine("You have selected  booking history menu");
                            BookingHistory();
                            break;
                        }
                        case 'd':
                        {
                            Console.WriteLine("You have selected wallet Recharge menu");
                            currentLoggedInUser.RechargeWallet();
                            break;
                        }
                        case 'e':
                        {
                            
                            Console.WriteLine("You have choosen the exit menu");
                            Console.WriteLine("Exicted from main menu");
                            choice="no";
                            break;
                        }
                    
                    }
                }while(choice=="yes");
            
            }
             

            public static void TicketBooking()
            {
                //Show list of theatre details
                foreach(TheaterDetails theaters in theaterList)
                {
                    theaters.ShowTheaterDetails();
                }

                //Get theatre Id from user
                Console.Write("Select any Theatre Id shown above: ");
                string theatreId1=Console.ReadLine().ToUpper();

                //Show list of movies on that particular theatre
                foreach(TheaterDetails theaters in theaterList)
                {
                    if(theaters.TheaterId==theatreId1)
                    {
                        foreach(ScreeningDetails screenings in screeningList)
                        {
                            if(theaters.TheaterId==screenings.TheaterId)
                            {
                                foreach(MovieDetails movies in movieList)
                                {
                                    if(movies.MovieId==screenings.MovieId)
                                    {
                                        movies.ShowMovieDetails();
                                    }
                                }
                            }
                        }
                    }
                }

                //Get movie id from the user
                Console.Write("Select any movie id shown above: ");
                string movieId1=Console.ReadLine().ToUpper();

                
                //Ask the seat count from user
                Console.Write("Enter the seat count: ");
                int seatCount=int.Parse(Console.ReadLine());

                //checking the movie id
                int temp=0;
                int count=0;
                foreach(ScreeningDetails screenings in screeningList)
                {
                    if(screenings.MovieId==movieId1)
                    {

                      if(theatreId1==screenings.TheaterId)
                       {
                            //Check seat count details
                         if(seatCount<=screenings.SeatAvailable)
                         {

                            //calculate the amount
                            double totalAmount=seatCount*screenings.TicketPrice+18/100;

                            //check amount with wallet balance
                            if(totalAmount<=currentLoggedInUser.WalletBalance)
                            {
                                //detuct amount from current user
                                currentLoggedInUser.WalletBalance -=totalAmount;

                                //Detect the seat count
                                screenings.SeatAvailable=screenings.SeatAvailable-seatCount;

                                //create object for booking details
                                BookingDetails currentBooking=new BookingDetails(currentLoggedInUser.UserId,movieId1,theatreId1,seatCount,totalAmount,BookingStatus.Booked);

                                //Add object top booking list
                                bookingList.Add(currentBooking);

                                //Show booked succedssfully message
                                Console.WriteLine("Booked Successfully");
                                count=1;

                                
                            }
                            temp=1;
                         }

                       }

                   }
                }

                 //show seat count is not available
                if(temp==0)
                {
                    Console.WriteLine("Required seat count is not available");
                }

                //show insufficient wallet balance
                if(count==0)
                {
                    Console.WriteLine("Insufficient Wallet Ballance. Please recharge you wallet");
                }


             

            } 
        
            public static void TicketCancellation()
            {
                  //Show booking history of current user
                  foreach(BookingDetails bookings in bookingList)
                  {
                     if(currentLoggedInUser.UserId==bookings.UserId)
                     {
                        bookings.ShowBookingDetails();
                     }
                 }

                  //Choose the booking id need to cancel
                  Console.Write("Select any booking id shown above: ");
                  string bookingId1=Console.ReadLine().ToUpper();

                  foreach(BookingDetails bookings in bookingList)
                  {
                    
                    //Checking with booking id
                    if(bookings.BookingId==bookingId1)
                    {

                        //checking booking status
                        if(bookings.Status==BookingStatus.Booked)
                        {
                            
                             foreach(ScreeningDetails screenings in screeningList)
                             {
                                if(screenings.MovieId==bookings.MovieId)
                                {

                                    //Adding the seat count 
                                    screenings.SeatAvailable+=bookings.SeatCount;

                                    //Reduce 20 Rs from total amount and add to current user
                                    currentLoggedInUser.WalletBalance +=bookings.TotalAmount-20;

                                    //change booking status to cancelled
                                    bookings.Status=BookingStatus.Cancelled;

                                    //change the seat count to zero
                                    bookings.SeatCount=0;

                                    bookings.TotalAmount=0;

                                   
                                }
                             }

                            //Display the message to user
                            Console.WriteLine("Ticket cancelled successfully");
                        }
                    }
                  }

                  
                     
                  
            }
        
            public static void BookingHistory()
            {
                //Show booking history of current user
                  foreach(BookingDetails bookings in bookingList)
                  {
                     if(currentLoggedInUser.UserId==bookings.UserId)
                     {
                        bookings.ShowBookingDetails();
                     }
                 }

            }
        
        
    }
}