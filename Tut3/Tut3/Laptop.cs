namespace DefaultNamespace;

public class Laptop : Equipment
{
    private string type { get; }
    private int RAM { get; }

    public Laptop(string name, 
        string type, int ram):base(name)
    {
        this.type = type; 
        RAM = ram;
    }
}