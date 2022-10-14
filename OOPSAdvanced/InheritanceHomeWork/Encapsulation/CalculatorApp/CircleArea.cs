using System;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea:Maths
    {
        protected int radius;  //Field

        public int Radius { get; set; }
        
        internal double Area { get; set; }

        public double pi { get; set;  }
        
         
        
        
        public double CalculateCircleArea()
        {
            Console.Write("Enter the radius: ");
            Radius=int.Parse(Console.ReadLine());
            Area=Radius*Radius*pi;
            Console.Write("The area of the circle is: "+Area);
            return Area;
        }

    }
}