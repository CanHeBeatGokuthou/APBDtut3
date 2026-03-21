namespace DefaultNamespace;

public abstract class Equipment
{
    public string name;
    public bool available;
    public long iD;
    
    

    public Equipment(string name, bool available)
    {
        this.name = name;
        this.available = available;
        iD = RandomIdGenerator.GenerateUniqueId();
    }
    
    
}