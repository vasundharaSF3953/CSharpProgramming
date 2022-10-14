using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbBillCalculation
{
    public class BillCalculation
    {
        private static int s_meterId=1000;    //Field Creation

        public string MeterId { get; set; }

        public string UserName { get; set; }

        public long  PhoneNumber{ get; set; }

        public string MailId { get; set; }

        public int UnitsUsed { get; set; }
        

        public BillCalculation(string userName,long phoneNumber,string mailId)
        {
            s_meterId++;
            MeterId="EB"+s_meterId;
            UserName=userName;
            PhoneNumber=phoneNumber;
            MailId=mailId;
            
        }

        public void CalculateAmount()
        {
            if(UnitsUsed>100 && UnitsUsed<=200)
            {
                int free=UnitsUsed-100;
                int unit1=free*3;
                Console.WriteLine("Eb Bill of the month is:"+unit1);
            }
            else if(UnitsUsed>200 && UnitsUsed<=400)
            {
                int free=UnitsUsed-100;
                 if(free>100 && free<=200)
                   {
                      int unit1=free-100;
                      int unit2=100*3;
                      int unit3=unit2+(unit1*5);
                      Console.WriteLine("Eb Bill of the month is:"+unit3);
                   }
                 else if(free>200 && free<=400)
                 {
                      int unit1=free-100;
                      int unit2=100*3;
                      int unit3=unit2+(unit1*5);
                      Console.WriteLine("Eb Bill of the month is:"+unit3);

                 }  

            }
             else if(UnitsUsed>400)
            {
                int free=UnitsUsed-100;
                 if(free<=400)
                 {
                      int unit1=free-100;
                      int unit2=100*3;
                      if(unit1>200)
                      {
                      int unit3=unit1-200;
                      int unit4=200*5;
                      int unit5=unit2+unit4+(unit3*6);
                      Console.WriteLine("Eb Bill of the month is:"+unit5);

                      }
                 }     
                 else if(free>400)
                 {
                      
                      int unit1=free-100;
                      int  unit2=100*3;
                      if(unit1>=200&&unit2<=400)
                      {
                        int unit3=unit1-200;
                        int unit4=200*5;
                        int unit5=unit2+unit4+(unit3*6);
                        Console.WriteLine("Eb Bill of the month is:"+unit5);
                      }
                      
                 }
            }
            else
            {
                Console.WriteLine("No Eb Bill for This Month");
            }
        }

        public void ShowDetails()
        {
            
            Console.WriteLine("EB Bill Calculation of a person");
            Console.WriteLine($"MeterId: {MeterId} \nUserName: {UserName} \nPhoneNumber: {PhoneNumber} \nMailId: {MailId} \nUnits Used: {UnitsUsed}");
            
        }

        public void NumberOfUnits()
        {
             Console.Write("Enter Number of units used: ");
             UnitsUsed=int.Parse(Console.ReadLine());
        }
        
    }
}
