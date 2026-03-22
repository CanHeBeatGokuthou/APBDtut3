namespace DefaultNamespace;

public class Employee:User
{
    public override int MaxRentals => 5;
    public string type { get; };

    public Employee(string name, string surname,string type) : base(name, surname)
    {
        this.type = type;
    }
    
}