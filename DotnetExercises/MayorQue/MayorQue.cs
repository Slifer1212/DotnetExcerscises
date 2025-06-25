namespace DotnetExercises.MayorQue;

public class MayorQue
{
    public static bool Greater<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0;
    }
}