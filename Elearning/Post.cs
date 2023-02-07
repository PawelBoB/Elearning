using Microsoft.VisualBasic;
using System;

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
