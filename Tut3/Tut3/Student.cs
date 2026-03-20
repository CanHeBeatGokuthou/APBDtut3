namespace DefaultNamespace;

public class Student:User
{
    private string type;

    public Student(string name, string surname,
        long id):base(name,surname,id)
    {
        type = "Student";
    }
    public string getType()
    {
        return type;
    }
}