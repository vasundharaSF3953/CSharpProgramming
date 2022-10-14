using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridQuestion2
{
    public class BankInfo:IdInfo
    {
        public string BankName { get; set; }
        
        public long IfscNumber { get; set; }
        
        public string Branch{ get; set; }
        
        public BankInfo(string name, Gender gender, DateTime dob, long phone, long mobile,long voterId, long aadharId, long panNumber,string bankName, long ifscNumber, string branch):base(name,gender, dob, phone, mobile,voterId, aadharId, panNumber)
        {
            BankName=bankName;
            IfscNumber=ifscNumber;
            Branch=branch;
        }

        public void ShowBankInfo()
        {
            ShowIdDetails();
            Console.WriteLine("BankName: "+BankName+"\n"+"IFSC: "+IfscNumber+"\n"+"Branch: "+Branch);
        }

    }
}