using System;
namespace Question12;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any string in numbers:");
        string number=Console.ReadLine();

        string[] splitData=number.Split(' ');

        int maximum=int.Parse(splitData[0]);
        int minimum=int.Parse(splitData[0]);
        for(int i=0;i<splitData.Length;i++)
        {
            int temp=int.Parse(splitData[i]);
            if(temp>maximum)
            {
                maximum=temp;
            }
            if(temp<minimum)
            {
                 minimum=temp;
            }
        }


        Console.WriteLine("Maximum and minimum of the string is said to be "+maximum+" ,"+minimum);
        
    }
}
