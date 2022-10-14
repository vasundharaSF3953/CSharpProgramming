using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelQuestion2
{
    public class BookInfo:DepartmentDetails    //Inherited
    {
        private static int s_bookId=100;

        public string BookId { get; set; }

        public string BookName { get; set; }

        public string AuthorName { get; set; }


        public int Price { get; set; }


        public BookInfo(string departmentName, string degree,string bookId, string bookName, string authorName, int price):base(departmentName, degree)
        {
            s_bookId++;
            BookId="BID"+s_bookId;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }

        public void ShowBookInfo()
        {
            Console.WriteLine("BookId: "+BookId);
            showDepartmentDetails();
            Console.WriteLine("BookName: "+BookName+"\n"+"Author Name: "+AuthorName+"\n"+"Price: "+Price);
        }
        
        
        
        
        
        
        
        
    }
}