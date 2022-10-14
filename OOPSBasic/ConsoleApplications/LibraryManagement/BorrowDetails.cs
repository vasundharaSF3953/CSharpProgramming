using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public enum Status{Borrowed, Issued,Returned}
    public class BorrowDetails
    {
        private static int s_borrowId=300;    //Field Creation

        public string BorrowId { get; set; }   //Property Creation

        public string BookId { get; set; }

        public string RegistrationId { get; set; }

        public DateTime BorrowedDate { get; set; }

        public Status Status { get; set; }



        //Parameterized constructor Creation
        public BorrowDetails(string bookId, string registrationId,DateTime borrowedDate, Status status)
        {
            s_borrowId++;
            BorrowId="LB"+s_borrowId;
            BookId=bookId;
            RegistrationId=registrationId;
            BorrowedDate=borrowedDate;
            Status=status;
   


        }
        
        
        
        
        
        
        
        
        
        
    }
}