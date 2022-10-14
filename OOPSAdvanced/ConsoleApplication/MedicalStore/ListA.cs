using System;


namespace MedicalStore
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

        public void Remove(int data)
        {
            _capacity=_capacity*2;
            Type[] remove=new Type[_capacity];
            int j=0;
            for(int i=0; i<_count;i++)
            {
               if(Array[i].Equals(data))
               {
                   i++;
               }
               j++;
               remove[i]=Array[i];
            }
         Array=remove;
         _count--;
        }

    }
}