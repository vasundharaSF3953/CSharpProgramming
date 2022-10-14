using System.Collections;


namespace ArrayList
{
    public partial class ArrayList:IEnumerable,IEnumerator
    {
        private int position;

        public IEnumerator GetEnumerator()
        {
            position=-1;
            //this current value
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            if(position<_count-1)
            {
                ++position;
                return true;
            }
            Reset();   //If no element in the list then reset the position value
            return false;
        }

        public void Reset() //reset i for next turn
        {
            position=-1;
        }

        public object Current //return the current array position value
        {
            get{ return Array[position];}
        }
    }
}