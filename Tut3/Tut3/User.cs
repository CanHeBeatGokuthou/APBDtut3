namespace DefaultNamespace;

public abstract class User
{
    private string name;
    private string surname;
    private long id;
    public User(string name, string surname, 
        long id)
    {
        this.name = name;
        this.surname = surname;
        this.id = id;
        
    }
}