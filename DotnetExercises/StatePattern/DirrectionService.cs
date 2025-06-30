namespace DotnetExercises.StatePattern;

public class DirrectionService
{
    public IMakeTravel MakeTravel { get; set; }

    public DirrectionService(IMakeTravel makeTravel)
    {
        MakeTravel = makeTravel;
    }


    public void SetState(IMakeTravel makeTravel)
    {
        MakeTravel = makeTravel;
        Console.WriteLine($"Modo de viaje cambiado a: {makeTravel.GetType().Name}");
    }


    public void GetDirections()
    {
        MakeTravel.GetDirection();
    }

    public void GetETA()
    {
        MakeTravel.GetEta();
    }
}