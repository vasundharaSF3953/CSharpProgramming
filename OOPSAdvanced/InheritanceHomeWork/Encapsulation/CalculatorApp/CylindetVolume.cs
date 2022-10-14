using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CylindetVolume:CircleArea
    {
        private int height;  //Field

        public int Height { get; set; }     //Property
        
        internal double volume {get; set;}    //property

        
        
        public void CalculateVolume()
        {
            volume=CalculateCircleArea()*Height;
            System.Console.WriteLine("The volume is:"+volume);

        }
    }
}