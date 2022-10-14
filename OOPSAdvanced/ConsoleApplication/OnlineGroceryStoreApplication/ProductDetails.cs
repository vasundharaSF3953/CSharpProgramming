using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{
    public class ProductDetails
    {
        private static int s_productId=100;

        public string ProductId { get;  }

        public string ProductName { get; set; }

        public int QuantityAvailable{ get; set; }

        public double PricePerQuantity { get; set; }
        
        
        public ProductDetails( string productName,int quantity, double price)
        {
            s_productId++;
            ProductId="PID"+s_productId;
            ProductName=productName;
            QuantityAvailable=quantity;
            PricePerQuantity=price;
        }


        public ProductDetails(string data)
        {
            string[] value=data.Split(',');
             s_productId=int.Parse(value[0].Remove(0,3));
            ProductId=value[0];
            ProductName=value[1];
            QuantityAvailable=int.Parse(value[2]);
            PricePerQuantity=double.Parse(value[3]);

        }
        public void ShowProductDetails()
        {
            Console.WriteLine("ProductId: "+ProductId+"\t"+"ProductName: "+ProductName+"\t"+"Quantity Available: "+QuantityAvailable+"\t"+"PricePerQuantity: "+PricePerQuantity);
        }
        
        
        
        
        
    }
}