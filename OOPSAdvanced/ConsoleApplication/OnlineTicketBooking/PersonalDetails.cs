using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketBooking
{
    public class PersonalDetails
    {
        public string Name { get; set; }
        
        public int Age { get; set; }
        
        public long PhoneNumber { get; set; }


        //Parameterized constructor
        public PersonalDetails(string name, int age, long phoneNumber)
        {
            Name=name;
            Age=age;
            PhoneNumber=phoneNumber;
        }

        public PersonalDetails(string data)
        {
            string[] value=data.Split(',');
            Name=value[1];
            Age=int.Parse(value[2]);
            PhoneNumber=long.Parse(value[3]);
        }


        //method to show person details
        public void ShowPersonalDetails()
        {
            Console.WriteLine("Person Details");
            Console.WriteLine(Name+"\n"+Age+"\n"+PhoneNumber);
        }
        
        
    }
}