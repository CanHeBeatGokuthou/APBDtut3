namespace DefaultNamespace;

public class Projector:Equipment
{
    private string model;
    private int displatDistance;

    public Projector(string name, bool available,
        long id, string model, int displatDistance) :
        base(name, available)
    {
        this.model = model;
        this.displatDistance = displatDistance;
    }
    
}