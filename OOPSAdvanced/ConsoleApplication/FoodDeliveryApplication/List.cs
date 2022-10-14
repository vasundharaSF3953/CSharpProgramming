using System;
using System.Collections;


namespace FoodDeliveryApplication
{
    public partial class List<Type>
    {

            private int _count;

        private int _capacity;

        public int  Count{ get{return _count;} }

        public int Capacity { get{return _capacity;} }

        private Type[] Array{get; set;}
        
        public Type this[int i]
        {get{return Array[i];}
        set{Array[i]=value;}}
        
        
        public List()
        {
            _count=0;
            _capacity=4;
            Array=new Type[_capacity];
        }

        public List(int size)
        {
            _count=0;
            _capacity=size;
            Array= new Type[_capacity];
        }

        public void Add(Type data)      
       {

        
        if(_count==_capacity)      //Check the count is equal to capacity    
        {
            GrowSize();
          
        }

         Array[_count]=data;         //Assign the given data to count
         _count++;                   //Increment the count number

       }

       public void GrowSize()
       {

        _capacity=_capacity*2;

        Type[] Array2=new Type[_capacity];

        for(int i=0; i<_count; i++ )   //Initialize a double size array of array
        {
           Array2[i]=Array[i]; 
        }
        Array=Array2; 
       }

      public void AddRange(List<Type> List)
      {

          Type[] newArray=new Type[_count+List._count];
          for(int i=0; i<_count; i++)
          {
            newArray[i]=Array[i];
          }
          for(int i=0; i<List._count; i++)
          {
            newArray[_count+i]=List[i];
          }
          Array=newArray;
          _count=_count+List._count;
      }
       
    
        
    }
}