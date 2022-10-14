using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleQuestion1
{
    public interface IFamilyInfo:iShowData
    {
          string FatherName { get; set; }
       
          string MotherName { get; set; }

          string Address{get; set;}

          int Siblings{get; set;}


          void ShowFamilyInfo(string fatherName, string motherName, string address, int siblings);

        //   void ShowInfo();
          
    }
}