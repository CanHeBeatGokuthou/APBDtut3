namespace DefaultNamespace;

public class Employee:User
{
    private string[] types = {"Professor", "Dean", "Librarian"};
    int random = Random.Shared.Next(3);
    string type;

    public Employee(string name, string surname) : base(name, surname)
    {
        type = types[random];
    }

    public string getType()
    {
        return type;
    }
}