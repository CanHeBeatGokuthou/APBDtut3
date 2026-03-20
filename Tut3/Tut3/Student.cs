namespace DefaultNamespace;

public class Student:User
{
    private string type;

    public Student(string name, string surname):base(name,surname)
    {
        type = "Student";
    }
    public string getType()
    {
        return type;
    }
}