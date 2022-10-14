using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Operations
    {
        static UserDetails currentUser=null;
        static List<UserDetails> UserDetailsList=new List<UserDetails>();   //List creation for user details

        static List<BookDetails> BookDetailsList=new List<BookDetails>();   //List creation for book details

        static List<BorrowDetails> BorrowDetailsList=new List<BorrowDetails>();   //List creation for Borrow details
        
        //MainMenu Method
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                Console.WriteLine("Select options 1.User Registration 2.User Login 3.Exit");
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
            Console.Write("Enter your Name: ");
            string name=Console.ReadLine();
            Console.Write("Enter your Gender: ");
            string gender=Console.ReadLine();
            Console.Write("Enter your Department: ");
            Departments department=Enum.Parse<Departments>(Console.ReadLine(), true);
            Console.Write("Enter your mobile number: ");
            long mobileNumber=long.Parse(Console.ReadLine());
            Console.Write("Enter your MailId: ");
            string mailId=Console.ReadLine();
            UserDetails user=new UserDetails(name,gender,department,mobileNumber,mailId);   //Object creation for user
            UserDetailsList.Add(user);    //Add object to list
            Console.WriteLine("Your user Id is : "+user.RegistrationId);

        }


        //Method for Login
        public static void Login()
        {
            Console.Write("Enter your UserId:");
            string userId1=Console.ReadLine();
            int temp=0;
            foreach(UserDetails users in UserDetailsList)
            {
                
                if(users.RegistrationId==userId1)
                {
                    Console.WriteLine("Valid User Id");
                    currentUser=users;
                    SubMenu();
                    temp=1;
                }
               
            }
            if(temp==0)
               
                {
                    Console.WriteLine("Invalid User Id");
                } 
        }

        //Method for SubMenu
        public static void SubMenu()
        {
            string choice="yes";
            do
            {
                Console.WriteLine("Select Options 1.Borrow Book 2.Return Book 3.Show Borrowed history 4.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("Borrow Book");
                        BorrowBook();
                        break;
                    }
                     case 2:
                    {
                        Console.WriteLine("Return Book");
                        ReturnBook();
                        break;
                    }
                     case 3:
                    {
                        Console.WriteLine("Show Borrowed history");
                        BorrowedHistory();
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
        //BorrowBook Method
        public static void BorrowBook()
        {
            //Show the list of books availability
            foreach(BookDetails books in BookDetailsList)
            {
                Console.WriteLine(books.BookId+"\t"+books.BookName+"\t"+books.AuthorName+"\t"+books.BookCount);
            }

            //Ask book Id from the user
            Console.WriteLine("Enter any one BookId from the list of books shown above:");
            string bookId1=Console.ReadLine();
            
            foreach(BookDetails books1 in BookDetailsList)
            {
                //Check Book Id
                if(books1.BookId==bookId1)
                {
                    //Check BookId count
                    if(books1.BookCount>1)
                    {
                        books1.BookCount--;
                         int count=0;
                        foreach(BorrowDetails borrow in BorrowDetailsList)
                        {
                            if(currentUser.RegistrationId==borrow.RegistrationId)
                            {
                                if(borrow.Status==Status.Issued)
                                {
                               
                                count=count+1;
                                }
                            }
                        }
                        if(count<3)
                        {
                            BorrowDetails borrow2=new BorrowDetails(books1.BookId,currentUser.RegistrationId,DateTime.Now,Status.Issued);
                            BorrowDetailsList.Add(borrow2);
                        }
                        else
                        {
                            Console.WriteLine("You have already taken 3 books.So yOU are not able to take another book");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Books are not available for selected BookId");
                        foreach(BorrowDetails borrow3 in BorrowDetailsList) 
                        {
                            if(borrow3.BookId==bookId1)
                            {
                                DateTime date1=borrow3.BorrowedDate;
                                date1=date1.AddDays(15);
                                Console.WriteLine("The Book will be available on "+date1.ToString("dd/MM/yyyy"));
                            }

                        }
                    }

                }
            }
        }

        //ReturnBook Mothod
        public static void ReturnBook()
        {
            foreach(BorrowDetails borrowBook in BorrowDetailsList)
            {
                if(currentUser.RegistrationId==borrowBook.RegistrationId)
                {
                    if(borrowBook.Status==Status.Issued)
                    {
                    DateTime date2=borrowBook.BorrowedDate;
                    date2=date2.AddDays(15);
                    Console.WriteLine("Return date of borrowed book is:"+date2.ToString("dd/MM/yyyy"));
                
                    TimeSpan timeSpan=DateTime.Now-new DateTime(date2.Year,date2.Month,date2.Day);
                    
                    int data=(int)timeSpan.TotalDays;
                    if(data>1)
                    {
                        int fineAmount=1*data;
                        Console.WriteLine("Your fine amount is : "+fineAmount);
                         borrowBook.Status=Status.Returned;
                         foreach(BookDetails books in BookDetailsList)
                         {
                            if(borrowBook.BookId==books.BookId)
                            {
                                books.BookCount++;
                            }
                         }
                    }
                    } 
                    
                }
            }
        }

        //BorrowedHistory Method
        public static void BorrowedHistory()
        {
            foreach(BorrowDetails borrowdetails in BorrowDetailsList)
            {
                if(currentUser.RegistrationId==borrowdetails.RegistrationId)
                {
                    Console.WriteLine(borrowdetails.BorrowId+"\t"+borrowdetails.BookId+"\t"+borrowdetails.RegistrationId+"\t"+borrowdetails.BorrowedDate+"\t"+borrowdetails.Status);
                }
            }
        }

        //Default method created for user details
        public static void DefaultUserDetails()
        {
            UserDetails user1=new UserDetails("Ravichandaran","Male",Departments.ECE,9938388333,"ravi@gmail.com");
            UserDetailsList.Add(user1);   //Add object to list
            UserDetails user2=new UserDetails("Priyadharshini","Female",Departments.CSE,9944444455,"priya@gmail.com");
            UserDetailsList.Add(user2);   //Add object to list
        }

        //Default method created  for Book Details
        public static void DefaultBookDetails()
            {
                BookDetails book1=new BookDetails("c#","Author1",3);
                BookDetailsList.Add(book1);
                BookDetails book2=new BookDetails("HTML","Author2",5);
                BookDetailsList.Add(book2);
                BookDetails book3=new BookDetails("CSS","Author1",3);
                BookDetailsList.Add(book3);
                BookDetails book4=new BookDetails("JS","Author1",3);
                BookDetailsList.Add(book4);
                BookDetails book5=new BookDetails("TS","Author2",2);
                BookDetailsList.Add(book5);
            }

        
        //Default method created for Borrowed Details
        public static void DefaultBorrowedDetails()
            {
                BorrowDetails borrow1=new BorrowDetails("BID101","SF3001",new DateTime(2022,04,10),Status.Issued);
                BorrowDetailsList.Add(borrow1);
                BorrowDetails borrow2=new BorrowDetails("BID103","SF3001",new DateTime(2022,04,12),Status.Returned);
                BorrowDetailsList.Add(borrow2);
                BorrowDetails borrow3=new BorrowDetails("BID104","SF3001",new DateTime(2022,04,15),Status.Issued);
                BorrowDetailsList.Add(borrow3);
                BorrowDetails borrow4=new BorrowDetails("BID102","SF3002",new DateTime(2022,04,11),Status.Issued);
                BorrowDetailsList.Add(borrow4);
                BorrowDetails borrow5=new BorrowDetails("BID105","SF3002",new DateTime(2022,04,15),Status.Returned);
                BorrowDetailsList.Add(borrow5);   //add object to list
            }
        
    }
}