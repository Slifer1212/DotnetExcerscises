namespace DotnetExercises.MementoPatter;

public class DocumentOriginator
{
    public string Content { get; set; }
    public string FontName  { get; set; }
    public int FontSize { get; set; }

    private int CursorPosition {get; set;}

    public DocumentOriginator(string content, string fontName, int fontSize)
    {
        Content = content;
        FontName = fontName;
        FontSize = fontSize;
    }

    public void Write(string text)
    {
        Content += text;
        CursorPosition += text.Length;
        Console.WriteLine($"Actual content: {Content}");
    }

    public void SetCursorPosition(int position)
    {
        if (position >= CursorPosition && position <= Content.Length)
        {
            this.CursorPosition = position;
        }
    }

    public DocumentMemento Save()
    {
        Console.WriteLine($"Saving content: {Content}");
        return new DocumentMemento(Content, CursorPosition , FontName , FontSize);
    }

    public void Restore(DocumentMemento documentMemento)
    {
        Content = documentMemento.State;
        CursorPosition =  documentMemento.CursorPosition;
        FontName = documentMemento.FontName;
        FontSize = documentMemento.FontSize;
        Console.WriteLine($"Restoring content: {Content}");
    }

    public void Clear()
    {
        Content = "";
        CursorPosition = 0;
        FontName = "";
        FontSize = 0;
        Console.WriteLine($"Restoring content: {Content}");
    }
}