using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayList
{
    public partial class ArrayList
    {
        private int _count;

        private int _capacity;

        public object[] Array {get; set;}

        public int Count {get{return _count;}}

        public int Capacity { get{return _capacity;}}
        
        
        public ArrayList()
        {
            _count=0;
            _capacity=4;
            Array=new object[_capacity];
        }

        public ArrayList(int size)
        {
            _count=0;
            _capacity=size;
            Array=new Array[_capacity];
        }

        public void Add(object value)
        {
            if(_capacity==_count)
            {
                GrowSize();
            }
            Array[_count]=value;
            _count++;
        }

        public void GrowSize()
        {
            object[] NewArray=new object[_capacity*2];
            for(int i=0; i<_count; i++)
            {
                NewArray[i]=Array[i];
            }
            Array=NewArray;
        }
    }
}