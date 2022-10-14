using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethod
{
    public class Dog:Animal      //Inherited Animal class in Dog class
    {
        public new  void MakeSound()
        {
            Console.WriteLine("Animal Sounds");
        }
    }
}