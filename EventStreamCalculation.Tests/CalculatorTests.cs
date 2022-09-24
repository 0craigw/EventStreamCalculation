namespace EventStreamCalculation.Tests;

public class CalculatorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Create_ShouldBeNotNull()
    {
        var actual = new Calculator();
        Assert.IsNotNull(actual);
    }
}