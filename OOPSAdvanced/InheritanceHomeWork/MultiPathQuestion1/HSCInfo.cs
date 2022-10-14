using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiPathQuestion1
{
    public interface IHSCInfo:IPersonalInfo
    {
       

        string MarkSheetNumber { get; set; }
        
        int Physics { get; set; }
        
        int Chemistry { get; set; }
        
        int Maths { get; set; }
        
        int Total { get; set; }
        
        double Percentage { get; set; }

        //long AdharNumber {get; set;}
        
        void ShowHscMarksheet();

         void CalculateHSC();


       
    }
}