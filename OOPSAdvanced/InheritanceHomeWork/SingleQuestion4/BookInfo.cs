using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleQuestion4
{
    public class BookInfo:Library
    {
        private static int s_bookId=100;  
        public string BookId { get; set; }

        public string BookName { get; set; }

        public string AuthorName { get; set; }

        public int Price{ get; set; }


        public BookInfo(Department departmentsName, string degree, string bookName,string authorName, int price):base(departmentsName, degree)
        {
            s_bookId++;
            BookId="BID"+s_bookId;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }

        public void ShowBookDetails()
        {
            ShowDetails();
            Console.WriteLine("BookId:"+BookId);
            Console.WriteLine("BookName:"+BookName);
            Console.WriteLine("AuthorName:"+AuthorName);
            Console.WriteLine("Price:"+Price);
        }
        
        
        
        
        
        
        
        
    }
}