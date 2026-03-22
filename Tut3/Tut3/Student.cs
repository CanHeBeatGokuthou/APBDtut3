namespace DefaultNamespace;

public class Student:User
{
    public override int MaxRentals => 2;

    public Student(string name, string surname) : base(name, surname)
    {
    }


}