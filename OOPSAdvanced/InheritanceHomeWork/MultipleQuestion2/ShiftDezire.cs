using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleQuestion2
{
    public class ShiftDezire:Car,IBrand
    {
        private static int s_makingId=1001;

        public string MakingId { get; set; }
        
        public int EngineNumber { get; set; }

        public string ChasisName { get; set; }

        public string BrandName { get; set; }

        public string ModelName { get; set; }
        
        
        
        
        

        public ShiftDezire(string fuleType, int seats, string color, int capacity,int kiloMeter,int engineNumber, string chasisName):base(fuleType, seats, color, capacity, kiloMeter)
        {
             s_makingId++;
             MakingId="MID"+s_makingId;
             EngineNumber=engineNumber;
             ChasisName=chasisName;
        }
        

        public void ShowShiftDezire()
        {
            Console.WriteLine("MakingId: "+MakingId+"\n"+"Engine Number: "+EngineNumber+"\n"+"Chasis Number: "+ChasisName);
            CalculateMilage();
        }
         
        public void ShowDetails(string brandName, string modelName)
        {
            BrandName=brandName;
            ModelName=modelName;
            Console.WriteLine("Brand Name: "+BrandName+"\n"+"Model Name: "+modelName);
        }
        
    }
}