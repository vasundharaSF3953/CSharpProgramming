using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethod
{
    public  class Animal
    {
        public virtual void MakeSound()      //Make this method as imaginary by using virtual keyword
        {
            Console.WriteLine("Animal Sounds");
        }
    }
}