using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelQuestion2
{
    public class RackInfo
    {
        private static int s_rackNumber=1;

        private static int s_columnNumber=1;

        public string RackNumber { get; set; }

        public string ColumnNumber { get; set; }
        
        public RackInfo(string rackInfo, string columnNumber)
        {
            s_rackNumber++;
            s_columnNumber++;
            RackNumber=RackNumber;
            ColumnNumber=columnNumber;

        }

        public void ShowRackInfo()
        {
            Console.WriteLine("RackNumber: "+RackNumber+"\n"+"ColumnNumber :"+ColumnNumber);
        }
        
        
    }
}