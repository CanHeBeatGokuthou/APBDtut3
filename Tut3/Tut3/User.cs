namespace DefaultNamespace;

public abstract class User:RandomIdGenerator
{
    private string name;
    private string surname;
    private long id;
    public User(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
        id = RandomIdGenerator.GenerateUniqueId();
    }
}