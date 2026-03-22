namespace DefaultNamespace;

public class Projector:Equipment
{
    private string model { get; }
    private int displatDistance { get; }

    public Projector(string name, string model, int displatDistance) :
        base(name)
    {
        this.model = model;
        this.displatDistance = displatDistance;
    }
    
}