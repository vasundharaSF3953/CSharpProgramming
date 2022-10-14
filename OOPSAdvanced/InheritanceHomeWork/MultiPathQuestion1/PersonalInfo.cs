using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiPathQuestion1
{

    public enum Gender{Female, Male, TransGender}
    public interface IPersonalInfo
    {
         long AdharNumber { get; set; }
        
        string Name { get; set; }
        

        string FatherName { get; set; }
        
        long Phone { get; set; }
        
        DateTime DOB { get; set; }
        
        Gender Gender{ get; set; }
        
       
    }
}