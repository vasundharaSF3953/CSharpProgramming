namespace TDD;

[TestFixture]
public class Tests
{

    Maths Operation=null;
    Maths Operation1=null;



    [SetUp]
    public void Setup()
    {
        Operation=new Maths();   //Object creation
        Operation1=new Maths();
    }

    [Test]
    public void Test1()
    {
        int result=Operation.Addition(10,11);
        Assert.That(result, Is.EqualTo(21));
    }


    [TestCase(10,20,30)]     //Multiple testcases input 1, input2, input3
    [TestCase(1,2,2)]
    public void IsAdditionOk(int value1, int value2, int result)
    {
        int output=Operation.Addition(value1,value2);
        Assert.AreEqual(output,result);
    }
    [TestCase("Ravi","Chsndran","RaviChandran")]
    public  void IsAdditionOk()
    
    [TestCase(1.2,2.1,3.3)]

    public void IsAdditionOk(double value1, double value2, double result)
    {
        double output=Operation1.Addition(value1, value2);
        Assert.AreEqual(output,result);
    }
    
}