namespace DotnetExercises.StatePattern;

public class DrivingService : IMakeTravel
{
    public void GetEta()
    {
        Console.WriteLine("Calculating ETA (driving)");
    }

    public void GetDirection()
    {
        Console.WriteLine("Calculating Direction (driving)");
    }
}