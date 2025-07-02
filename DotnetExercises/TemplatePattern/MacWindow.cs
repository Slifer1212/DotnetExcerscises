namespace DotnetExercises.TemplatePattern;

public class MacWindow : BaseWindow
{
    public override void Show()
    {
        Console.WriteLine("MacWindow");
        BeforeClosing();
        AfterClosing();
    }

    protected override void BeforeClosing()
    {
        Console.WriteLine("MacWindow, before closing");
    }

    protected override void AfterClosing()
    {
        Console.WriteLine("MacWindow, after closing");
    }
}