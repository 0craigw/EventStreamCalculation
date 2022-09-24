namespace EventStreamCalculation;

public static class Calculator
{
    public static AnimalState Do(IEnumerable<AnimalEvent> animalEvents)
    {
        var animalState = new AnimalState();
        foreach (var animalEvent in animalEvents)
        {
            if (animalEvent.EventType == EventTypes.Mating)
            {
                animalState.Pregnant = true;
            }
        }

        return animalState;
    }
}

public class AnimalEvent
{
    public EventTypes EventType { get; init; }
}

public enum EventTypes
{
    Mating
}

public class AnimalState
{
    public bool Pregnant { get; set; }
}