namespace DotnetExercises.StrategyPattern;

public class DesSendAlgothrim : IEncryptMessage
{
    public void Send(string message)
    {
        Console.WriteLine("Encripte DesSendAlgothrim");
    }
}