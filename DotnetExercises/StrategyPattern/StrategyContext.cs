namespace DotnetExercises.StrategyPattern;

public class StrategyContext
{
    private IEncryptMessage _encryptMessage;

    public StrategyContext(IEncryptMessage encryptMessage)
    {
        _encryptMessage = encryptMessage;
    }

    public void SetStrategy(IEncryptMessage encryptMessage)
    {
        _encryptMessage = encryptMessage;
    }

    public void ExecuteStrategy(string message)
    {
        _encryptMessage.Send(message);
    }
}