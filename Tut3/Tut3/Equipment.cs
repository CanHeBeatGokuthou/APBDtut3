namespace DefaultNamespace;

public abstract class Equipment
{
    string name;
    bool available;
    private long iD;
    

    public Equipment(string name, bool available, 
        long iD)
    {
        this.name = name;
        this.available = available;
        this.iD = iD;
    }
    
    
}