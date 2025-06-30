namespace DotnetExercises.MementoPatter;

public class DocumentMemento
{
    public  string State { get;}
    public int CursorPosition { get; }
    public string FontName  { get;  }
    
    public int FontSize { get;  }


    public DocumentMemento(string state, int cursorPosition, string fontName , int fontSize)
    {
        State = state;
        CursorPosition = cursorPosition;
        FontName = fontName;
        FontSize = fontSize;
    }
}