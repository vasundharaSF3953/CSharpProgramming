using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{

    public enum BookingStatus{Initiated, Booked, Cancelled}
    public class BookingDetails
    {
        private static int s_bookingId=3000;

        public string BookingId { get;  }

        public string CustomerId { get; set; }

        public double TotalPrice { get; set; }

        public DateTime DateOfBooking { get; set; }

        public BookingStatus Status { get; set; }


        public BookingDetails(string customerId, double totalPrice,DateTime dateOfBooking, BookingStatus status)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            CustomerId=customerId;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            Status=status;
        }

        public BookingDetails(string data)
        {
            string[] value=data.Split(',');
            s_bookingId=int.Parse(value[0].Remove(0,3));
            BookingId=value[0];
            CustomerId=value[1];
            TotalPrice=int.Parse(value[2]);
            DateOfBooking=DateTime.ParseExact(value[3],"dd/MM/yyyy",null);
            Status=Enum.Parse<BookingStatus>(value[4]);

        }

        public void ShowBookingDetails()
        {
            Console.WriteLine("BookingId: "+BookingId+"\t"+"CustomerId: "+CustomerId+"\t"+"TotalPrice: "+TotalPrice+"\t"+"DateOfBooking:"+DateOfBooking.ToShortDateString()+"\t"+"Status: "+Status);
        }
        
        
        
        
        
        
        
        
        
        
    }
}