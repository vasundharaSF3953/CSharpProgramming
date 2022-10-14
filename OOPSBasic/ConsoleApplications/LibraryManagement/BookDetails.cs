using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class BookDetails
    {
        private static int s_bookId=100;   //Field Creation

        public string BookId { get; set; }   //Property Creation

        public string BookName { get; set; }

        public string AuthorName { get; set; }

        public int BookCount { get; set; }


        //Parameterized Constructor creation
        public BookDetails(string bookName, string authorName, int bookCount)
        {
            s_bookId++;
            BookId="BID"+s_bookId;
            BookName=bookName;
            AuthorName=authorName;
            BookCount=bookCount;

        }
        
        
        
        
        
        
        
        
    }
}