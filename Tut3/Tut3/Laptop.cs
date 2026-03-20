namespace DefaultNamespace;

public class Laptop : Equipment
{
    private string type;
    private int RAM;

    public Laptop(string name, bool available,
        long id, string type, int ram):base(name,available,id)
    {
        this.type = type; 
        RAM = ram;
    }
}