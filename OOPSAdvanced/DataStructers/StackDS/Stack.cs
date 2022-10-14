using System;


namespace StackDS
{
    public partial class Stack<Type>
    {
         private Type[] Array{get; set;}

         private int count;    //Field

         private int capacity;

        public int Count { get{return count;} }

        public Stack()         //Default constructor
        {
            count=0;
            capacity=4;
             Array=new Type[capacity];
        }


        public Stack(int size)    //Parameterized constructor
        {
            count=0;
            capacity=size;
            Array=new Type[capacity];
        }


        public void Push(Type data)
        {
            if(count==capacity)
            {
                GrowSize();
            }
            Array[count]=data;
            count++;
        }
         

         public void GrowSize()
         {
            capacity=capacity*2;
            Type[] Array1=new Type[capacity];
            for(int i=0; i<count; i++)
            {
                Array1[i]=Array[i];
            }
            Array=Array1;
         }


         public Type Pop()
         {
            Type value=default(Type);
             if(count<0)
             {
                Console.WriteLine("Empty Stack");
             }
             
             else if(count>=0)
             {
                value=Array[count];
                count--;
             }
             return value;
         }

         public bool Contains(Type data)
         {
            bool value=false;
            for(int i=0;i<count; i++)
            {
                if(Array[i].Equals(data))
                 {
                     return value;
                 }
                //  else
                //  {
                //     return value;
                //  }
            }
            return value;
         }

         public Type Peek()
         {
            Type value=default(Type);
             if(count<0)
             {
                Console.WriteLine("Empty Stack");
             }
             
             else if(count>=0)
             {
                value=Array[count];
                count--;
             }
             return value;

         }
         
    }
}