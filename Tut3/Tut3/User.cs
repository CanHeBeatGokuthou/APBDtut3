namespace DefaultNamespace;

public abstract class User
{
    public string name;
    public string surname;
    public long id;
    public User(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
        id = RandomIdGenerator.GenerateUniqueId();
    }
}