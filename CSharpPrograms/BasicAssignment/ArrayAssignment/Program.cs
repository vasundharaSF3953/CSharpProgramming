using System;
namespace ArrayAssignment;
class Program
{
    public static void Main(string[] args)
    {

        Console.Write("Enter the size of the array: ");
        int size=int.Parse(Console.ReadLine());

        String[] names=new String[size];

        
        for(int i=0;i<names.Length;i++)
        {
            Console.WriteLine("Enter the name:");
            names[i]=Console.ReadLine();
        }


        for(int i=0; i<names.Length;i++)
        {
           Console.WriteLine(names[i]); 
        }

       

        Console.WriteLine("Enter any name:");
        String name=Console.ReadLine();
        int temp=0;
        for(int i=0; i<names.Length; i++)
        {
            if(name==names[i])
            {
              Console.WriteLine("The name is present in the array"); 
              Console.WriteLine($"The index position of that name is: {i}"); 
              temp=1;
            }
        }
        if(temp==0)
        {
              Console.WriteLine("The name is not present in the array");
        }    
           


        foreach(string i in names)
        {
            if(name==i)
             {
              Console.WriteLine("The name is present in the array"); 
               temp=1;
            }
        
        }
        if(temp==0)
        {
              Console.WriteLine("The name is not present in the array");
        }  
        



    }
}
