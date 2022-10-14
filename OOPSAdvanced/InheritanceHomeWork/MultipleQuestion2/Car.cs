using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleQuestion2
{
    public class Car
    {
        public string FuelType { get; set; }

        public int NumberOfSeats { get; set; }

        public string Color { get; set; }

        public int TankCapacity { get; set; }

        public int KiloMeter { get; set; }

        public int Milage { get; set; }
        
        
        
        
        public Car(string fuleType, int seats, string color, int capacity,int kiloMeter)
        {
            FuelType=FuelType;
            NumberOfSeats=seats;
            Color=color;
            TankCapacity=capacity;
            KiloMeter=kiloMeter;
        }

        


        public void CalculateMilage()
        {
            Console.WriteLine("Fuel Type: "+FuelType+"\n"+"Number Of Seats: "+NumberOfSeats+"\n"+"Color: "+Color+"\n"+"Tank Capacity: "+TankCapacity+"\n"+"Kilometer Driven: "+KiloMeter);
            Milage=KiloMeter/TankCapacity;
            Console.WriteLine("Milage of the car is: "+Milage);
        }
        
        
        
        
        
        
        
        
    }
}