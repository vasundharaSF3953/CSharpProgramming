using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApplication
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
        
        
        
        
        
        
        
        
        
        
        
        
        
        


    }
}