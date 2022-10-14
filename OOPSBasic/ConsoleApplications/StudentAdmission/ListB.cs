using System;
using System.Collections;

namespace StudentAdmission
{
    public partial class List<Type>:IEnumerable,IEnumerator
    {

        private int Position;
        public IEnumerator GetEnumerator()
        {
            Position=-1;
            return(IEnumerator)this;
        }

        public bool MoveNext()
        {
            if(Position<_count -1)
            {
                ++Position;
            }
            Reset();
            return false;
        }


        public void Reset()
        {
            Position= -Position;
        }

        public object Current
        {
            get{return Array[Position];}
        }
        
        
    }
}