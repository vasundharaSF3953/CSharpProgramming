using System;


namespace DictionaryDS
{
    public class KeyValue<Tkey, Tvalue>
    {
        public Tkey key{get; set;}
  
        public Tvalue value{get; set;}
    }


    public partial class Dictionary<Tkey, Tvalue>
    {
        private int _count;         //Field

        private int _capacity;      //Field

        public int Count  {get{return _count;}}       //Property

        public int Capacity {get{return _capacity;}}   //Property

        public KeyValue<Tkey, Tvalue>[] Array {get; set;}    //Array Declare with key value

        public Dictionary()      //Default Constructor
        {
            _count=0;
            _capacity=4;
            Array=new KeyValue<Tkey, Tvalue>[_capacity];
        }

        public Dictionary(int size)    //Parameterized constructor
        {
            _count=0;
            _capacity=size;
            Array=new KeyValue<Tkey, Tvalue>[_capacity];
        }

         public void Add(Tkey key, Tvalue value)      
       {

        
        if(_count==_capacity)      //Check the count is equal to capacity    
        {
            GrowSize();            //call GrowSize method
          
        }
         bool temp=LinearSearch(key, out int index);
        if(temp==true)
        {
            Console.WriteLine("Duplicate Key");
        }

             KeyValue<Tkey,Tvalue> entry=new KeyValue<Tkey, Tvalue>();
             entry.key=key;
             entry.value=value;
             Array[_count]=entry;
             _count++;     
       }

       public void GrowSize()
       {

        _capacity=_capacity*2;

        KeyValue<Tkey,Tvalue>[] Array1=new KeyValue<Tkey, Tvalue>[_capacity];

        for(int i=0; i<_count; i++ )   
        {
           Array1[i]=Array[i]; 
        }
        Array=Array1; 
       }

       public bool LinearSearch(Tkey data, out int index)
       {
        bool temp=false;
        index=0;
        for(int i=0; i<Count; i++)
        {
            if((Array[i].key).Equals(data))
            {
                index=i;
                temp=true;
                break;
            }
         
        }
        return temp;

       }

       public Tvalue this [Tkey key]  
       {
          get
          {
             Tvalue output=default(Tvalue);
             int index=0;
             bool temp=LinearSearch(key, out index);
             if(temp)
             {
                output=Array[index].value;
             }
             else
             {
                Console.WriteLine("Invalid Key");
             }
             return output;
          }

          set
          {
            int position=0;
            bool temp=LinearSearch(key,out position);
            if(temp)
            {
                Array[position].value=value;
            }
            else
            {
                Console.WriteLine("Invalid Key");
            }
          }
       }
        
    }
}