using System.Collections;

namespace OnlineTicketBooking
{
    public partial class List<Type>
    {
        private int _count;   //Field Creation

        private int _capacity;  //Field creation

        private Type[] Array{get; set;}  

        public int Count { get{return _count;} }    //Property creation

        public int Capacity { get{return _capacity;} }


        public Type this[int i]
        {
            get{return Array[i];}
            set{Array[i]=value;}
        }
        
     
        //Default constructor
        public List()
        {
            _count=0;
            _capacity=4;
            Array= new Type[_capacity];
        }  


        //Parameterized Constructor
        public List(int size)
        {
            _count=0;
            _capacity=size;
            Array= new Type[_capacity];

        } 


         //Add method
        public  void Add(Type data) 
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            Array[_count]=data;
            _count++;

        } 

        //GrowSize Method
        public void GrowSize()
        {
            _capacity=_capacity*2;
            Type[] Array1=new Type[_capacity];
            for(int i=0; i<_count;i++)
            {
                Array1[i]=Array[i];
            }
            Array=Array1;
            
        }  
        
        
    }
}