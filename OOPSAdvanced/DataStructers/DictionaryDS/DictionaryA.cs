using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryDS
{
    public partial class Dictionary<Tkey, Tvalue>
    {
        public bool ContainsKey(Tkey key)
        {
           
            int position=0;
            bool data=LinearSearch(key,out position);
            return data;
        }
        
         public bool Remove(Tkey key)
        {
          KeyValue<Tkey, Tvalue>[] Array2=new KeyValue<Tkey, Tvalue>[_count];
          bool temp=false;
          int position=0;
          //bool data=LinearSearch(key, out position);
          for(int i=0;i<Count; i++)
          {
             if((key).Equals(Array[i].key))
             {
                i++;
                temp=true;
             }
              position++;
              Array2[i]=Array[i];
          }
          Array=Array2;
          _count--;
          return temp;
        }

        public KeyValue<Tkey, Tvalue> ElementAt(Tkey index)
        {
            KeyValue<Tkey, Tvalue> output=null;
            int position=0;
            bool temp=LinearSearch(index, out position);
            if(position>-1 && position<Count)
            {
                output=Array[position];
            }
            else
            {
                System.Console.WriteLine("Key not found");
            }
            return output;
        }



        public bool ContainsValue(Tvalue value)
        {
            bool temp=false;
            for(int i=0; i<_count; i++)
            {
                if(Array[i].value.Equals(value))
                {
                        temp=true;
                }
                
            }
            return temp;
        }
    }
}