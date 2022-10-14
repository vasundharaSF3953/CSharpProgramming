using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketBooking
{
    public class TheaterDetails
    {
        private static int s_theatreId=300;

        public string TheaterId { get; set; }
        
        public string TheatreName { get; set; }
        
        public string Location { get; set; }
        

        //Parameterized constructor
        public TheaterDetails(string theaterName, string location)
        {
            s_theatreId++;
            TheaterId="TID"+s_theatreId;
            TheatreName=theaterName;
            Location=location;
        }


        //constructor for file read
        public TheaterDetails(string data)
        {
            string[] value=data.Split(',');
            s_theatreId=int.Parse(value[0].Remove(0,3));
            TheaterId=value[0];
            TheatreName=value[1];
            Location=value[2];

        }


  

        //Show Theater details method
        public void ShowTheaterDetails()
        {
            
            Console.WriteLine(TheaterId+"\t"+TheatreName+"\t"+Location);
        }
    }
}