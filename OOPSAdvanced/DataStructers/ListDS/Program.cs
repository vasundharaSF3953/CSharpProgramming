using System;
namespace ListDS;

class Program
{
    public static void Main(string[] args)
    {
         List<int> datas=new List<int>();   //Object creation 
         datas.Add(10);
        for(int i=0; i<datas._count; i++)
        {
            Console.WriteLine(datas[i]);
        }


        foreach(int data in datas)
        {
            Console.WriteLine(data);
        }

         datas.Insert(2,10);
         datas.RemoveAt(2);
         datas.Remove(2);

         Console.WriteLine("Capacity:"+datas._capacity);
         Console.WriteLine("Count:"+datas._count);
    }
}
