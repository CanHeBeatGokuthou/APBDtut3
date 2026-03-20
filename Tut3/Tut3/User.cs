namespace DefaultNamespace;

public abstract class User
{
    private string name;
    private string surname;
    private long id;
    private string type;
    public User(string name, string surname, 
        long id, string type)
    {
        this.name = name;
        this.surname = surname;
        this.id = id;
        this.type = type;
    }
}