using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApplication
{
    public class OrderDetails
    {
        private static int s_orderID=100;    //Field creation

        public string OrderID { get; set; }  //property creation
        
        public string BookingID { get; set; }
        
        public string FoodId { get; set; }
        
        public int PurchaseCount { get; set; }
        
        public int PriceOfOrder { get; set; }
        

        //parameterized constructor
        public OrderDetails(string bookingID, string foodID, int purchaseCount, int priceOfOrder)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            BookingID=bookingID;
            FoodId=foodID;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
        }

        public OrderDetails(string data)
        {
            string[] values=data.Split(',');
            s_orderID=int.Parse(values[0].Remove(0,3));
            OrderID=values[0];
            BookingID=values[1];
            FoodId=values[2];
            PurchaseCount=int.Parse(values[3]);
            PriceOfOrder=int.Parse(values[4]);

        }

        public void ShowOrderDetails()
        {
            Console.WriteLine("OrderID: "+OrderID+"\n"+"BookingID: "+BookingID+"\n"+"FoodID: "+FoodId+"\n"+"PurchaseCount: "+PurchaseCount+"\n"+"PriceOfOrder: "+PriceOfOrder);
        }
    }
}