using System;
namespace DictionaryDS;
class Program
{
    public static void Main(string[] args)
    {
        Dictionary<long, string> dictionary=new Dictionary<long, string>();
        dictionary.Add(1,"Vasu");
        dictionary.Add(2,"chennai");
        dictionary.Add(3,"21");
        dictionary.Remove(2);
        dictionary.ContainsKey(1);
        dictionary.ContainsValue("21");

        foreach(Dictionary<long, string> data in dictionary )
        {
            Console.WriteLine(data);
        }

    }
}