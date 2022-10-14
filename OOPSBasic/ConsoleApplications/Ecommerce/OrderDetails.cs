using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce
{
    public enum OrderStatus{Ordered, Cancelled}
    public class OrderDetails
    {
        private static int s_orderId=1000;
       
        public string OrderId { get; set; }
        
        
        public string CustomerId { get; set; }

        public string ProductId { get; set; }

        public int TotalPrice { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int Quantity { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public OrderDetails(string customerId, string productId, int totalPrice, DateTime purchaseDate, int quantity, OrderStatus orderStatus)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            CustomerId=customerId;
            ProductId=productId;
            TotalPrice=totalPrice;
            PurchaseDate=purchaseDate;
            Quantity=quantity;
            OrderStatus=orderStatus;
        }
        
        public OrderDetails(string data)
        {
            string[] values=data.Split(',');
            s_orderId=int.Parse(values[0].Remove(0,3));
            OrderId=values[0];
            CustomerId=values[1];
            ProductId=values[2];
            TotalPrice=int.Parse(values[3]);
            PurchaseDate=DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
            Quantity=int.Parse(values[5]);
            OrderStatus=Enum.Parse<OrderStatus>(values[6]);

        }
        
        
        
        
        
        
        
        
        
        
        
        
        


    }
}