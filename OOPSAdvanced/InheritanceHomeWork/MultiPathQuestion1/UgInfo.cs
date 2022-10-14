using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiPathQuestion1
{
    public interface IUgInfo:IPersonalInfo
    {
      

        string UGMarkSheetNumber { get; set; }
        
        int Sem1 { get; set; }
        
        int Sem2 { get; set; }
        
        int Sem3 { get; set; }
        
        int Sem4 { get; set; }
        
        int TotalValue { get; set; }
        
        double PercentageData { get; set; }
        
        void ShowUgMarkSheet();

        void CalculateUg();
        
       
    }
}