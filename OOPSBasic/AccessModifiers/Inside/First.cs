using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;
namespace Inside
{
    public class First :Third
    {
        public int PublicNumber=10; //Create public access modifier

        private int PrivateNumber=20; 

        public int PrivateOutput{get{return PrivateNumber;}} //property creation

        internal int InternalNumber=30;

        protected int ProtectedNumber=40;

        public int ProtectedInternalOutput{get{return ProtectedInternalNumber ;}}

        
    }
}