using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public interface iMarkDetails
    {

        //No field
        int Physics{ get; set; }    //Property declaration only allowed

        int Chemistry{ get; set; }
  

         int Maths{ get; set; }

        int Total{ get; set; }

        double Average{ get; set; }


        //No constructor and object
        void Calculate();   //Method deClaration only allowed
        
        void GetMark(int physics, int chemistry, int maths);

        void ShowMark();

       
       
        
    }
}