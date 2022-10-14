using System;


namespace MedicalStore
{
    public class UserDetails
    {
        private static int s_userId=1000;

        public string UserId { get; set; }
        
        public string UserName { get; set; }
        
        public int Age{ get; set; }
        
        public string City { get; set; }
        
        public long PhoneNumber{ get; set; }
        
         public int Balance { get; set; }
         
         public UserDetails(string name, int age, string city, long phoneNumber, int balance)
         { 
            s_userId++;
            UserId="UID"+s_userId;
            UserName=name;
            Age=age;
            City=city;
            PhoneNumber=phoneNumber;
            Balance=balance;

         }

          public UserDetails(string data )
         { 
            string[] values=data.Split(',');
            s_userId=int.Parse(values[0].Remove(0,3));
            UserId=values[0];
            UserName=values[1];
            Age=int.Parse(values[2]);
            City=values[3];
            PhoneNumber=long.Parse(values[4]);
            Balance=int.Parse(values[5]);

         }

         public void ShowUserDetails()
         {
             Console.WriteLine("User Id: "+UserId+"\n"+"UserName: "+UserName+"\n"+"Age: "+Age+"\n"+"City: "+City+"\n"+"Phone Number: "+PhoneNumber+"\n"+"Balance: "+Balance);
         }
        
    }
}