using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethod
{
    public class Puppy:Dog
    {
        //try to override the sealed method
         public override void MakeSound()
        {
            Console.WriteLine("Animal Sounds");
        }
        
    }
}