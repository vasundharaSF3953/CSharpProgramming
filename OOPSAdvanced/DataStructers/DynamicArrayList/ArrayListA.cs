


namespace ArrayList
{
    public partial class ArrayList
    {
        public void Insert(int data,object value)
        {
            _capacity=_capacity+1;

            object[] newArray=new object[_capacity];
            for(int i=0;i<_count; i++)
            {
                if(data<i)
                {
                    newArray[i]=Array[i];
                }
                else if(data==i)
                {
                    newArray[i]=value;
                }
                else
                {
                    newArray[i]=Array[i-1];
                }
            }
            Array=newArray;
        }

        public void RemoveAt(int index)
        {
            for(int i=0; i<_count; i++)
            {
                if(i<index)
                {
                    Array[i]=Array[i];
                }
                if(i>=index)
                {
                    Array[i]=Array[i+1];
                }
            }
            _count--;
        }

        public void Remove(object data)
        {
            object[] remove=new object[_capacity*2];
            int j=0;

            for(int i=0; i<_count; i++)
            {
                if(Array[i].Equals(data))
                {
                    i++;
                }
                j++;
                remove[j]=Array[i];
            }
            Array=remove;
            _count--;
        }


        public bool IndexOf(int index)
        {
            bool n=false;
            for(int i=0; i<_count; i++)
            {
                if(i==index)
                {
                    n=true;
                
                }
            }
            return false;
        }
    }
}