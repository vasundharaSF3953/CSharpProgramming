using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApplication
{
    public interface IBalance
    {
         int WalletBalance {get; set;}    //declare the property

         void WalletRecharge();    //declare method
    }
}