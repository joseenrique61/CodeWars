using NUnit.Framework;
using CodeWars;

[TestFixture]
public class DescendingOrderTests
{
    [Test]
    public void Test0()
    {
        Assert.AreEqual(0, DescendingOrder.Excercise(0));
    }

    [Test]
    public void Test1021()
    {
        Assert.AreEqual(2110, DescendingOrder.Excercise(1021));
    }

    [Test]
    public void Test123456789()
    {
        Assert.AreEqual(987654321, DescendingOrder.Excercise(123456789));
    }

    [Test]
    public void Test15()
    {
        Assert.AreEqual(51, DescendingOrder.Excercise(15));
    }
    
    [Test]
    public void Test550105679()
    {
        Assert.AreEqual(976555100, DescendingOrder.Excercise(550105679));
    }

    [Test]
    public void Test1321()
    {
        Assert.AreEqual(3211, DescendingOrder.Excercise(1321));
    }
}