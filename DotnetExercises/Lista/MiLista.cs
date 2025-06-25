namespace DotnetExercises;

public class MiLista<T>
{
    private List<T> Lista = new List<T>();

    public void AddItem(T item)
    {
        Lista.Add(item);
    }

    public void SeeAllItems()
    {
        foreach (var Variable in Lista)
        {
            Console.WriteLine(Variable);
        }
    }

    public void GetItemIndex(T item)
    {
        if (!Lista.Contains(item))
            Console.WriteLine("Item not found");
        else 
            Console.WriteLine(Lista.IndexOf(item));
    }
}