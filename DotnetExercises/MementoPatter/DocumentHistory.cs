namespace DotnetExercises.MementoPatter;

public class DocumentHistory
{
    private readonly Stack<DocumentMemento> _history;

    public DocumentHistory(Stack<DocumentMemento> history)
    {
        _history = history;
    }

    public void Push(DocumentMemento memento)
    {
        _history.Push(memento);
    }

    public DocumentMemento Pop()
    {
        return _history.Count > 0 ? _history.Pop() : null!;
    }
    
    public bool IsEmpty() => _history.Count == 0;
    
    
}