using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        
        Console.Write("Enter any string : ");
        string stringData=Console.ReadLine();

         Console.Write("Enter the substring to be searched: ");
        string searchData=Console.ReadLine();

        string[] splitData1=stringData.Split(new string[] {" "}, StringSplitOptions.None);
        int count1=splitData1.Length;
        

        

      for(int i=0; i<count1; i++)
      {
         if(searchData==splitData1[i])
         {
            Console.WriteLine("The sub string exist in the given string "); 
         }  

      }
          
        
    }
}
