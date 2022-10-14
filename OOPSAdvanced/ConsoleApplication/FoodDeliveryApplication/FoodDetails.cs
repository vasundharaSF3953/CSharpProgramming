using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApplication
{
    public class FoodDetails
    {

        private static int s_foodId=100;    //Field

        public string FoodID { get; set; }  //Property
        
        public string FoodName { get; set; }

        public int Price { get; set; }
        
        //Parameterized constructor
        public FoodDetails(string foodName, int price)
        {
              s_foodId++;
              FoodID="FID"+s_foodId;
              FoodName=foodName;
              Price=price;
        }

        public FoodDetails(string data)
        {
            string[] values=data.Split(',');
            s_foodId=int.Parse(values[0].Remove(0,3));
            FoodID=values[0];
            FoodName=values[1];
            Price=int.Parse(values[2]);
        }

        public void ShowFoodDetails()
        {
            Console.WriteLine("FoodID: "+FoodID+"\n"+"FoodName: "+FoodName+"\n"+"Price: "+Price);
        }
        
        
    }
}