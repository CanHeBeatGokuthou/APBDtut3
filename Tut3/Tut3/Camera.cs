namespace DefaultNamespace;

public class Camera:Equipment
{
    private string companyName;
    private string resolution;

    public Camera(string name, bool available,
        long id, string companyName, string resolution) :
        base(name, available)
    {
        this.companyName = companyName;
        this.resolution = resolution;
    }
    
}