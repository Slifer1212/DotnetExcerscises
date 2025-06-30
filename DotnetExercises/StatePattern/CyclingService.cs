namespace DotnetExercises.StatePattern;

public class CyclingService : IMakeTravel
{
    public void GetEta()
    {
        Console.WriteLine("Calculating ETA (bicycling");
    }

    public void GetDirection()
    {
        Console.WriteLine("Calculating Direction (bicycling)");
    }
}