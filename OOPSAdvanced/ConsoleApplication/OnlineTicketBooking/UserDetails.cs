using System;


namespace OnlineTicketBooking
{
    public class UserDetails:PersonalDetails,IWallet
    {
        //static field for user id
        private static int s_userId=1000;

        //property for userid
        public string UserId { get; set; }

        //property for walletBalance
        public double WalletBalance {get; set;}


        //Parameterized constructor
        public UserDetails(string name, int age, long phoneNumber,double walletBalance):base(name, age, phoneNumber)
        {
            s_userId++;
            UserId="UID"+s_userId;
            WalletBalance=walletBalance;
       }
         

         public UserDetails(string data):base(data)
         {
            string[] value=data.Split(',');
            s_userId=int.Parse(value[0].Remove(0,3));
            UserId=value[0];
            WalletBalance=double.Parse(value[4]);

         }
      

        //Method for recharge wallet
        public void RechargeWallet()
        {
            Console.Write("Enter the amount need to be recharge: ");
            WalletBalance+=double.Parse(Console.ReadLine());
            Console.WriteLine("Current available balance is: "+WalletBalance);
            
        }



        //Method to show user details
        public void ShowUserDetails()
        {
             
            Console.WriteLine(UserId+"\t"+Name+"\t"+Age+"\t"+PhoneNumber+"\t"+WalletBalance);
        }
    }
}