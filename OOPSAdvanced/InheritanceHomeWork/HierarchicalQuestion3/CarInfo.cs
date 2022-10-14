using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalQuestion3
{
    public class CarInfo
    {
        private static int s_rcBookNumber=1000;

        public string RCBookNumber { get; set; }


        public int EngineNumber { get; set; }

        public int ChasisNumber { get; set; }

        public int Milage{ get; set; }

        public int TankCapacity { get; set; }

        public int NumberOfSeats { get; set; }

        public int NumberOfKmDriven { get; set; }

        public DateTime DateOfPurchase { get; set; }
        
        
        public CarInfo(int engineNumber, int chasisNumber, int milage, int tankCapacity, int numberOfSeats, int numberOfKmDriven, DateTime dateOfPurchase)
        {
            s_rcBookNumber++;
            RCBookNumber="RCNO"+s_rcBookNumber;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
            Milage=milage;
            TankCapacity=tankCapacity;
            NumberOfSeats=numberOfSeats;
            NumberOfKmDriven=numberOfKmDriven;
            DateOfPurchase=dateOfPurchase;
        }

         public CarInfo(string rcBookNumber,int engineNumber, int chasisNumber, int milage, int tankCapacity, int numberOfSeats, int numberOfKmDriven, DateTime dateOfPurchase)
        {
            
            RCBookNumber= rcBookNumber;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
            Milage=milage;
            TankCapacity=tankCapacity;
            NumberOfSeats=numberOfSeats;
            NumberOfKmDriven=numberOfKmDriven;
            DateOfPurchase=dateOfPurchase;
        }
        
        public void Milages()
        {
            Console.WriteLine("Enter how many litters need to fill the petrol tank:");
            TankCapacity=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many km driven:");
            NumberOfKmDriven=int.Parse(Console.ReadLine());
            Milage=TankCapacity/NumberOfKmDriven;
            System.Console.WriteLine("Millage of the car is:"+Milage);
            
            
        }


        public void ShowCarInfo()
        {
            Console.WriteLine("RCBookNumber:"+RCBookNumber+"\n"+"EngineNumber:"+EngineNumber+"\n"+"ChasisNumber:"+ChasisNumber+"\n"+"Milage:"+Milage+"\n"+"TankCapacity:"+TankCapacity+"\n"+"NumberOfSeats:"+NumberOfSeats+"\n"+"NumberOfKmDriven:"+NumberOfKmDriven+"\n"+"DateOfPurchase:"+DateOfPurchase);
        }
        
        
        
        
        
        
        
        
        
        
        
        
    }
}