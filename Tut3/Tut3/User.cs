namespace DefaultNamespace;

public abstract class User
{
    public string name { get; }
    public string surname { get; }
    public long id { get; } = RandomIdGenerator.GenerateUniqueId();

    public abstract int MaxRentals { get; }

    public User(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }

    public override string ToString()
    {
        return $"{name} {surname} ({GetType().Name})";
    }
}