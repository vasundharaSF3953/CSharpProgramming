using System;
using System.IO;

namespace OnlineTicketBooking
{
    public class Files
    {
        
        //Creating Files and Folder for online ticket booking
        public static void Create()
        {
            //Creating Folder
            if(!Directory.Exists("OnlineTicketBooking"))
            {
                Console.WriteLine("Creating File");
                Directory.CreateDirectory("OnlineTicketBooking");
            }

            //Creating File for user details
            if(!File.Exists("OnlineTicketBooking/UserDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("OnlineTicketBooking/UserDetails.csv");
            }

            //Creating File for booking tickets
            if(!File.Exists("OnlineTicketBooking/BookingDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("OnlineTicketBooking/BookingDetails.csv");
            }

            //Creating File for movie details
            if(!File.Exists("OnlineTicketBooking/MovieDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("OnlineTicketBooking/MovieDetails.csv");
            }

            //Creating File for screening Details
            if(!File.Exists("OnlineTicketBooking/ScreeningDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("OnlineTicketBooking/ScreeningDetails.csv");
            }

            //Creating File for screening Details
            if(!File.Exists("OnlineTicketBooking/TheaterDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("OnlineTicketBooking/TheaterDetails.csv");
            }
        }

        public static void ReadFile()
        {

            //Read content for user details
            string[] user=File.ReadAllLines("OnlineTicketBooking/UserDetails.csv");
            foreach(string data in user)
            {
                UserDetails user1=new UserDetails(data);
                Operations.userList.Add(user1);
            }

            //Read content for Booking Details
            string[] booking=File.ReadAllLines("OnlineTicketBooking/BookingDetails.csv");
            foreach(string data in booking)
            {
                BookingDetails booking1=new BookingDetails(data);
                Operations.bookingList.Add(booking1);
            }


            //Read content for movie Details
            string[] movie=File.ReadAllLines("OnlineTicketBooking/MovieDetails.csv");
            foreach(string data in movie)
            {
                MovieDetails movie1=new MovieDetails(data);
                Operations.movieList.Add(movie1);
            }

            //Read content for Screening Details
            string[] screening=File.ReadAllLines("OnlineTicketBooking/ScreeningDetails.csv");
            foreach(string data in screening)
            {
                 ScreeningDetails screening1=new ScreeningDetails(data);
                 Operations.screeningList.Add(screening1);
            }

            //Read content fromTheater Details
            string[] theater=File.ReadAllLines("OnlineTicketBooking/TheaterDetails.csv");
            foreach(string data in theater)
            {
                TheaterDetails theater1=new TheaterDetails(data);
                Operations.theaterList.Add(theater1);
            }
        }

        
        //Write the content to Files
        public static void WriteToFiles()
        {
            //Write content for user details
            string[] user=new string[Operations.userList.Count];
            for(int i=0; i<Operations.userList.Count; i++)
            {
                user[i]=Operations.userList[i].UserId+","+Operations.userList[i].Name+","+Operations.userList[i].Age+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].WalletBalance;
            }
            File.WriteAllLines("OnlineTicketBooking/UserDetails.csv",user);

            //write content for booking Details
            string[] booking=new string[Operations.bookingList.Count];
            for(int i=0; i<Operations.bookingList.Count; i++)
            {
                booking[i]=Operations.bookingList[i].BookingId+","+Operations.bookingList[i].UserId+","+Operations.bookingList[i].MovieId+","+Operations.bookingList[i].TheatreId+","+Operations.bookingList[i].SeatCount+","+Operations.bookingList[i].TotalAmount+","+Operations.bookingList[i].Status;
            }
            File.WriteAllLines("OnlineTicketBooking/BookingDetails.csv",booking);

            //write content to movie Details
            string[] movie=new string[Operations.movieList.Count];
            for(int i=0; i<Operations.movieList.Count; i++)
            {
                movie[i]=Operations.movieList[i].MovieId+","+Operations.movieList[i].MovieName+","+Operations.movieList[i].Language;
            }
            File.WriteAllLines("OnlineTicketBooking/MovieDetails.csv",movie);

            //write content to Screening details
            string[] screening=new string[Operations.screeningList.Count];
            for(int i=0; i<Operations.screeningList.Count; i++)
            {
                screening[i]=Operations.screeningList[i].MovieId+","+Operations.screeningList[i].TheaterId+","+Operations.screeningList[i].SeatAvailable+","+Operations.screeningList[i].TicketPrice;
            }
            File.WriteAllLines("OnlineTicketBooking/ScreeningDetails.csv",screening);

            //write content to theater details
            string[] theater=new string[Operations.theaterList.Count];
            for(int i=0; i<Operations.theaterList.Count; i++)
            {
                theater[i]=Operations.theaterList[i].TheaterId+","+Operations.theaterList[i].TheatreName+","+Operations.theaterList[i].Location;
            }
            File.WriteAllLines("OnlineTicketBooking/TheaterDetails.csv",theater);

        }




    }
}