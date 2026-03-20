namespace DefaultNamespace;

public class Employee:User
{
    private string[] types = {"Professor", "Dean", "Librarian"};
    int random = Random.Shared.Next(3);
    string type;

    public Employee(string name, string surname,
        long id) : base(name, surname, id)
    {
        type = types[random];
    }

    public string getType()
    {
        return type;
    }
}