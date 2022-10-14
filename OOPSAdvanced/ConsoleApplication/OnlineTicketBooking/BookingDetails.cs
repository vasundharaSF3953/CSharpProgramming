using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketBooking
{
    public enum BookingStatus{Booked, Cancelled}
    public class BookingDetails
    {
        //Static field for bookingid
        private static int s_bookingId=7000;

        //property for booking Id
        public string BookingId { get; set; }
        
        //Property for userId
        public string UserId { get; set; }
        
        //Property for movieId
        public string MovieId { get; set; }
        
        //Property for theaterId
        public string TheatreId { get; set; }

        //Property for seatcount
        public int SeatCount{ get; set; }
        
        //property for total amount
        public double TotalAmount { get; set; }
        
        //Property for status
        public BookingStatus Status { get; set; }

         
         //Parameterized constructor
        public BookingDetails(string userId, string movieId, String theatreId, int seatCount, double totalPrice,BookingStatus status)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            UserId=userId;
            MovieId=movieId;
            TheatreId=theatreId;
            SeatCount=seatCount;
            TotalAmount=totalPrice;
            Status=status;
        }


        public BookingDetails(string data)
        {
            string[] value=data.Split(',');
            s_bookingId=int.Parse(value[0].Remove(0,3));
            BookingId=value[0];
            UserId=value[1];
            MovieId=value[2];
            TheatreId=value[3];
            SeatCount=int.Parse(value[4]);
            TotalAmount=double.Parse(value[5]);
            Status=Enum.Parse<BookingStatus>(value[6]);
        }
        

       //Method to show booking details
        public void ShowBookingDetails()
        {
           Console.WriteLine(BookingId+"\t"+UserId+"\t"+MovieId+"\t"+TheatreId+"\t"+SeatCount+"\t"+TotalAmount+"\t"+Status);
        }        
    }
}