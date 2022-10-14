using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApplication
{

    public enum BookingStatus{Default, Initiated, Booked, Cancelled}
    public class BookingDetails
    {
        private static int s_bookingId=3001;  //Field

        public string BookingID { get; set; }
        
        public string CustomerID { get; set; }
        
        public int TotalPrice { get; set; }
        
        public DateTime DateOfBooking { get; set; }
        
        public BookingStatus Status { get; set; }
        
         
         public BookingDetails(string customerID,int totalPrice, DateTime dateOfBooking, BookingStatus status)
         {
             s_bookingId++;
             BookingID="BID"+s_bookingId;
             CustomerID=customerID;
             TotalPrice=totalPrice;
             DateOfBooking=dateOfBooking;
             Status=status;
         }

         public BookingDetails(string data)
          {
            string[] values=data.Split(',');
             s_bookingId=int.Parse(values[0].Remove(0,3));
             BookingID=values[0];
             CustomerID=values[1];
             TotalPrice=int.Parse(values[2]);
             DateOfBooking=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
             Status=Enum.Parse<BookingStatus>(values[4]);
         }


         public void ShowBookingDetails()
         {
             Console.WriteLine("BookingID: "+BookingID+"\n"+"CustomerID: "+CustomerID+"\n"+"Total Price: "+TotalPrice+"\n"+"DateOfBooking: "+DateOfBooking+"\n"+"Booking Status: "+Status);
         }
    }
}