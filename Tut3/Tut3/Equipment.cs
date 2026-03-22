namespace DefaultNamespace;

public abstract class Equipment
{
    public string name { get; }
    public bool available { get; set; } = true;
    public long iD { get; } = RandomIdGenerator.GenerateUniqueId();

    public Equipment(string name)
    {
        this.name = name;
    }
    public override string ToString()=>$"{name} [{GetType().Name}] - {(available ? "Available" : "Unavailable")}";
    
    
}