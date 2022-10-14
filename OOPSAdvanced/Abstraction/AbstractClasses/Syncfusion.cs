using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Syncfusion:AbstractBase    //Inherited the base class
    {
        public override string Name {get{return name;}set{name=value;}}   //Abstract Property definition

        public override void Salary(int dates)        //Abstract method definition
        {
               Display();   //Call the normal method
               Amount=(double)dates*500;
               Console.WriteLine(Amount);
        }
    }
}