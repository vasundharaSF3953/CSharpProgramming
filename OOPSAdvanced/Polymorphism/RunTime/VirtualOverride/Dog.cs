using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualOverride
{
    public class Dog:Animal      //Inherited Animal class in Dog class
    {
        public override  void MakeSound()
        {
            Console.WriteLine("Animal Sounds");
        }
    }
}