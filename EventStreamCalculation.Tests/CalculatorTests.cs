namespace EventStreamCalculation.Tests;

public class CalculatorTests
{
    [Test]
    public void WhenNoEvents_ShouldNotBePregnant()
    {
        var events = Array.Empty<AnimalEvent>();
        var actual = Calculator.Do(events);
        Assert.That(actual.Pregnant, Is.False);
    }
    
    [Test]
    public void WhenMated_ShouldBePregnant()
    {
        var events = new[] { new AnimalEvent{ EventType = EventTypes.Mating}};
        var actual = Calculator.Do(events);
        Assert.That(actual.Pregnant, Is.True);
    }
}