using System;


namespace MedicalStore
{

    public enum OrderStatus{Purchased,Cancelled}
    public class OrderDetails
    {
        private static int s_orderId=2000;

        public string OrderId { get; set; }
        
        public string UserId { get; set; }
        
        public string MedicineId { get; set; }

        public int MedicineCount { get; set; }
        
        public int TotalPrice { get; set; }
        
        public DateTime OrderDate { get; set; }
        
        public OrderStatus OrderedStatus { get; set; }
        
        
        public OrderDetails(string userID, string medicineId, int medicineCount, int totalPrice, DateTime orderDate, OrderStatus order )
        {
            
            s_orderId++;
            OrderId="OID"+s_orderId;
            UserId=userID;
            MedicineId=medicineId;
            MedicineCount=medicineCount;
            TotalPrice=totalPrice;
            OrderDate=orderDate;
            OrderedStatus=order;

        }

        public OrderDetails(string data)
         {
            
            string[] values=data.Split(',');
            s_orderId=int.Parse(values[0].Remove(0,3));
            OrderId=values[0];
            UserId=values[1];
            MedicineId=values[2];
            MedicineCount=int.Parse(values[3]);
            TotalPrice=int.Parse(values[4]);
            OrderDate=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            OrderedStatus=Enum.Parse<OrderStatus>(values[6]);

        }

        public void ShowOrderedDetails()
        {
            Console.WriteLine("OrderId: "+OrderId+"\n"+"UserId: "+UserId+"\n"+"MedicineId: "+MedicineId+"\n"+"MedicineCount: "+MedicineCount+"\n"+"TotalPrice:"+TotalPrice+"\n"+"OrderDate: "+OrderDate+"\n"+"OrderStatus: "+OrderedStatus);
        }
    }
}