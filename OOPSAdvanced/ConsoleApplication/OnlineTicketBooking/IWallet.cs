using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketBooking
{
    public interface IWallet
    {
        double WalletBalance {get; set;}     //property declare
       void RechargeWallet();      //method declare

    }
}