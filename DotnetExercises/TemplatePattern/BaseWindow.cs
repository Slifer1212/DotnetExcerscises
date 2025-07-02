namespace DotnetExercises.TemplatePattern;

public abstract class BaseWindow
{

    public abstract void Show();
    protected virtual void BeforeClosing(){}
    
    protected virtual void AfterClosing(){}

    public void Close()
    {

        Console.WriteLine("=== Closing Window ===");

        BeforeClosing();


        AfterClosing();

        Console.WriteLine("=== Window Closed ===\n");
    }

}