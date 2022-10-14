using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueueDS
{
    public partial class Queue<Type>
    {
        private int _count;    //Field
        private int _capacity;

        private int _tail;

        private int _head;

        public int Count { get; set; }   //Property

        private Type[] Array{get; set;}  //Array


        public Queue()
        {
            _count=0;
            _capacity=4;
            _head=0;
            _tail=0;
            Array = new Type[_capacity];

        }

        public Queue(int size)
        {
            _count=0;
            _capacity=size;
            _head=0;
            _tail=0;
            Array = new Type[_capacity];
        }


        public void Enqueue(Type data)
        {
            if(_tail==_capacity)
            {
                GrowSize();
            }
            Array[_tail]=data;
            _tail++;
            _count++;
        }
        
        public void GrowSize()
        {
            _capacity=_capacity*2;

            Type[] Array2=new Type[_capacity];
            for(int i=0; i<_tail; i++)
            {
                Array2[i]=Array[i];
            }
            Array=Array2;
        }

        public Type Dqueue()
        {
             Type value=default(Type);
             if(_head>=_tail)
             {
                Console.WriteLine("Empty Queue");
             }
             else
             {
                value=Array[_head];
                _head++;
                _count--;

             }
             return value;
        }

         public Type Peek()
        {
             Type value=default(Type);
             if(_head>=_tail)
             {
                Console.WriteLine("Empty Queue");
             }
             else
             {
                value=Array[_head];
                

             }
             return value;
        }

      
      




         public bool Contains(Type data)
         {
            bool value=false;
            for(int i=0;i<_count; i++)
            {
                if(Array[i].Equals(data))
                 {
                     return value;
                 }
                 else
                 {
                    return value;
                 }
            }
            return value;
         }

    }
}