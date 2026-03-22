namespace DefaultNamespace;

public class Camera:Equipment
{
    private string companyName { get; }
    private string resolution { get; }

    public Camera(string name
        , string companyName, string resolution) :
        base(name)
    {
        this.companyName = companyName;
        this.resolution = resolution;
    }
    
}