namespace DefaultNamespace;

public abstract class Equipment:RandomIdGenerator
{
    string name;
    bool available;
    private long iD;
    

    public Equipment(string name, bool available)
    {
        this.name = name;
        this.available = available;
        iD = RandomIdGenerator.GenerateUniqueId();
    }
    
    
}