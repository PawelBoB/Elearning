using Microsoft.VisualBasic;
using System;

/*https://docs.google.com/document/d/1yBWzXRuxmOQiPQs9TyNx8tNgq6nWF42Sjn-mgT_-5nY/edit?usp=sharing*/

public class Post
{
    private string name;
    private int salary;
    private Division division;
    public Post(string name, int salary, Division division)
    {
        this.name = name;
        this.salary = salary;
        this.division = division;
    }
}
