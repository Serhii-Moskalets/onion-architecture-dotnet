using ChurchBulletin.Core;
using Shouldly;

namespace ChurchBulletin.UnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var class1 = new Class1();
        class1.ShouldNotBeNull();
    }
}