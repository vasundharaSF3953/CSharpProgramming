using System;


namespace StudentAdmission
{
    public  partial class List<Type>      //To include the data type in object give <Type> after the class name
    {

       
      public int _count;     //Field creation

       public int _capacity;

       private Type[] Array{get; set;}    //Array Declare

    

       public int Capacity { get{return _count;} }      //Remove set because only need to read the data

        public int Count { get{return _capacity;} }        //Property creation

        public Type this[int i]
        {get{return Array[i];}
        set{Array[i]=value;}}
       
       public List()      //Default constructor
       {
         _count=0;
         _capacity=4;
         Array = new Type[_capacity];

       }
       
       public List(int size)      //Parameterized Constructor
       {
        _count=0;
        _capacity=size;
        Array= new Type[_capacity];
       }


       //Add method creation
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


       
        
    }
}