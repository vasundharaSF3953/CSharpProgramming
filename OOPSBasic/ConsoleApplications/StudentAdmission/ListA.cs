

namespace StudentAdmission
{
    public partial class List<Type>
    {
        public void Insert(int index, Type data)
        {
           
            _capacity++;
            Type[] Insert=new Type[_capacity];

            for(int i=0; i<Count; i++)
            {
                if(index==i)
                {
                    Insert[i]=data;
                    
                }
                else if(i<index)
                {
                    Insert[i]=Array[i];
                
                }
                else
                {
                    Insert[i]=Array[i-1];
                   
                }
                  
            }
             Insert=Array; 
            
            _count++;
         
        }

        public void RemoveAt(int index)
        {
           for(int i=0; i<_count; i++)
           {
            if(i>=index)
            {
                Array[i]=Array[i+1];
            }
            _count--;
           }
           
        }

        public void Remove(int data)
        {
            for(int i=0; i<_count;i++)
            {
               if(i==data)
               {
                Array[i]=Array[i+1];
               }
            }
            _count--;
        }

    }
}