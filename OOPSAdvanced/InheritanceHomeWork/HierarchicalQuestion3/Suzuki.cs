using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalQuestion3
{
    public class Suzuki:CarInfo   //Inherited
    {
        
        private static int s_carModelNumber=1000;

        public string CarModelNumber { get; set; }

        public string CarModelName { get; set; }
        

        public Suzuki(string rcBookNumber,int engineNumber, int chasisNumber, int milage, int tankCapacity, int numberOfSeats, int numberOfKmDriven, DateTime dateOfPurchase,string carModelName):base(rcBookNumber,engineNumber, chasisNumber, milage, tankCapacity, numberOfSeats, numberOfKmDriven, dateOfPurchase)
        {
            s_carModelNumber++;
            CarModelNumber="SKI"+s_carModelNumber;
            CarModelName=carModelName;
        }


        public void ShowSuzukiDetails()
        {
            Console.WriteLine("CarModelNumber:"+CarModelNumber);
            ShowCarInfo();
            Milages();
            Console.WriteLine("CarModelName:"+CarModelName);
        }
    }
}