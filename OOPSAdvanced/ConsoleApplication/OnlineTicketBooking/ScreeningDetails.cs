using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketBooking
{
    public class ScreeningDetails
    {
        public string MovieId { get; set; }
        
        public string TheaterId { get; set; }
        
        public int SeatAvailable { get; set; }
        
        public double TicketPrice { get; set; }


        //Parameterized constructor
        public ScreeningDetails(string movieId, string theaterId,double ticketPrice, int seatAvailable )
        {
            MovieId=movieId;
            TheaterId=theaterId;
            TicketPrice=ticketPrice;
            SeatAvailable=seatAvailable;
        }


        public ScreeningDetails(string data)
        {
            string[] value=data.Split(',');
            MovieId=value[0];
            TheaterId=value[1];
            TicketPrice=double.Parse(value[2]);
            SeatAvailable=int.Parse(value[3]);

        }


        //Show screening details method
        public void ShowScreeningDetails()
        {
            
            Console.WriteLine(MovieId+"\t"+TheaterId+"\t"+SeatAvailable+"\t"+TicketPrice);
        }
        
         
    }
}