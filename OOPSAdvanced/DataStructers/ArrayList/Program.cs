using System;
namespace ArrayList;

class Program
{
public static void Main(string[] args)
{
    ArrayList list=new ArrayList();
    list.Add(20);
    list.Add("vasu");
    list.Add(23.9);
    list.Add('d');

  foreach(object list1 in list)
  {
    System.Console.WriteLine(list1);
  }

}
}