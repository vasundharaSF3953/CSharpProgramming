using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class AbstractBase        //Created class as abstract classs
    {
        protected string name;   //Protected Field

        public  abstract string Name { get; set; }   //Abstract Property because of using abstract keyword

        public double Amount{ get; set; }   //Normal Property

        public void Display()         //Normal Method  - non-abstract element
        {
            Console.WriteLine(name);

        }   

        public abstract void Salary(int dates);  //Abstract Method
        
        
        
        
        
        
    }
}