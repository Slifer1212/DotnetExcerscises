namespace DotnetExercises.GenerecInterface;

public interface IDentificable<TId>
{
    public void GetById(TId id);
}