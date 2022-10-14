using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApplication
{
    public class ProductDetails
    {
        private static int s_productId=100;    //Field Creation

        public string ProductId { get; set; }   //Property Creation
        
        public string ProductName { get; set; }

        public int Price { get; set; }

        public int Stock{ get; set; }

        public int ShippingDuration { get; set; }
        
        
        public ProductDetails(string productName,int stock,int price, int shippingDuration)
        {
            s_productId++;
            ProductId="PID"+s_productId;
            ProductName=productName;
            Stock=stock;
            ShippingDuration=shippingDuration;
        }
        
        
        
        
        
    }
}