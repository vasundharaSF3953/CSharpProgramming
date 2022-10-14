using System;
namespace HierarchicalQuestion3;

class  Program
{
    public static void Main(string[] args)
    {
        CarInfo car=new CarInfo(2345,6688,100,2500,5,8,new DateTime(2022,01,09));
        car.Milages();
        car.ShowCarInfo();

        Tata tata1=new Tata("1234",7788,2222,100,3000,5,5,new DateTime(2022,01,09),"TATA");
        tata1.ShowTataDetails();

        Suzuki suzuki1=new Suzuki("1234",7788,2222,100,3000,5,5,new DateTime(2022,01,09),"SUZUKI");
        suzuki1.ShowSuzukiDetails();

    }
}
