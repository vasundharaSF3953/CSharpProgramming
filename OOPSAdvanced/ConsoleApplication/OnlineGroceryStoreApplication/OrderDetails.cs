using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{
    public class OrderDetails
    {
        private static int s_orderId=100;

        public string OrderId { get;  }

        public string BookingId { get; set; }

        public string ProductId { get; set; }

        public int PurchaseCount{ get; set; }

        public double PriceOfOrder { get; set; }


        public OrderDetails( string bookingId, string productId, int purchase, double priceOfOrder)
        {

            s_orderId++;
            OrderId="OID"+s_orderId;
            BookingId=bookingId;
            ProductId=productId;
            PurchaseCount=purchase;
            PriceOfOrder=priceOfOrder;
        }

        public OrderDetails(string data)
        {
            string[] value=data.Split(',');
            s_orderId=int.Parse(value[0].Remove(0,3));
            OrderId=value[0];
            BookingId=value[1];
            ProductId=value[2];
            PurchaseCount=int.Parse(value[3]);
            PriceOfOrder=double.Parse(value[4]);

        }

        public void ShowOrderDetails()
        {
            Console.WriteLine("OrderId: "+OrderId+"\t"+"BookingId: "+BookingId+"\t"+"ProductId: "+ProductId+"\t"+"PurchaseCount: "+PurchaseCount+"\t"+"PriceOfOrder: "+PriceOfOrder);
        }
        
        
        
        
        
        
        
        
        
        
    }
}