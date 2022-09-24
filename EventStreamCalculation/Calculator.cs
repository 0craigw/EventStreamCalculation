namespace EventStreamCalculation;

public class Calculator
{
    public static AnimalState Do(AnimalEvent[] animalEvents)
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
    public EventTypes EventType { get; set; }
}

public enum EventTypes
{
    Mating
}

public class AnimalState
{
    public bool Pregnant { get; set; }
}