using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketBooking
{
    public class MovieDetails
    {
        //Static Field
        private static int s_movieId=500;       

        //Property for movieId
        public string MovieId { get; set; }
        
        //property for movie name
        public string MovieName { get; set; }
        

        //property for language
        public string Language { get; set; }
        

        //Parameterized constructor
        public MovieDetails(string movieName, string language)
        {
            s_movieId++;
            MovieId="MID"+s_movieId;
            MovieName=movieName;
            Language=language;
        }

        public MovieDetails(string data)
        {
            string[] value= data.Split(',');
            s_movieId=int.Parse(value[0].Remove(0,3));
            MovieId=value[0];
            MovieName=value[1];
            Language=value[2];
        }

        //Show movie details method
        public void ShowMovieDetails()
        {
            Console.WriteLine(MovieId+"\t"+MovieName+"\t"+Language);
        }
    }
}