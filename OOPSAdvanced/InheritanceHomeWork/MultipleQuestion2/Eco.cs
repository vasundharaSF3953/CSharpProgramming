using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleQuestion2
{
    public class Eco:Car,IBrand
    {
        private static int s_makingId=1000;

        public string MakingId { get; set; }
        
        public int EngineNumber { get; set; }

        public string ChasisNumber { get; set; }

        public string BrandName {get; set;}


        public string ModelName { get; set; }
        
        

        public Eco(string fuleType, int seats, string color, int capacity,int kiloMeter,int engineNumber, string chasisNumber):base(fuleType, seats, color, capacity, kiloMeter)
        {
           s_makingId++;
           MakingId="MID"+s_makingId;
           EngineNumber=engineNumber;
           ChasisNumber=chasisNumber;

        }

        public void ShowDetails(string brandName, string modelName)
        {
            BrandName=brandName;
            ModelName=modelName;
            Console.WriteLine("Brand Name: "+BrandName+"\n"+"Model Name: "+modelName);
        }

        public void ShowEcoDetails()
        {
            Console.WriteLine("MakingId: "+MakingId+"\n"+"EngineNumber: "+EngineNumber+"\n"+"ChasisNumber: "+ChasisNumber);
            CalculateMilage();
        }
        
        
        
        
    }
}