using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the lower limit:");
        int lower=int.Parse(Console.ReadLine());

        Console.Write("Enter the upper limit:");
        int upper=int.Parse(Console.ReadLine());


       
        int temp, number,value;

        for(int i=lower;i<=upper;i++)
        {
          number =0;
          temp=i;
          while(temp>0)
          {
            value=temp%10;
            if(i<10)
            {
                number+=value;
            }
            else if(i<100)
            {
                number+=value*value;
            }
            else
            {
                number+=value*value*value;
            }
            temp/=10;
          }
          if(i ==number)
          {
             Console.Write(i+ " ");
          }

        }
        
    }
}
