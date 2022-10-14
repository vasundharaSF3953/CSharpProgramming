using System;
namespace SingleQuestion4;
class Program
{
    public static void Main(string[] args)
    {
        Library department=new Library(Department.CSE,"BE");
        department.ShowDetails();

        BookInfo book1=new BookInfo(Department.CSE,"BE","Python","Vasu",500);
        book1.ShowBookDetails();
    }
}
