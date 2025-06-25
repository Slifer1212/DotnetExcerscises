namespace DotnetExercises;

public class Caja<T>
{
    public T? Contenido { get; set; }
    public void MostarContenido()
    {
        Console.WriteLine(Contenido);
    }
}