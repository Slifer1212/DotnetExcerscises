namespace DotnetExercises.StrategyPattern;

public class AesSendAlgorithm : IEncryptMessage
{
    public void Send(string message)
    {
        Console.WriteLine("Aes encrypt message:");
    }
}