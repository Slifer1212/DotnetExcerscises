namespace DotnetExercises.GenerecInterface;

public class Person : IDentificable<int>
{
    public Person(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void GetById(int id)
    {
        if (id == Id)
        {
            Console.WriteLine($"{FirstName} {LastName} id is equal to {Id}");
        }
        else
        {
            Console.WriteLine($"{id} not found");
        }
    }
}