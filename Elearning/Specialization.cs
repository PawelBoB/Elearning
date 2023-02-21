using Microsoft.VisualBasic;
using System;

public class Specialization
{
    private readonly string name;
    private readonly string abbreviation;
    public string Name { get => name; }
    public string Abbreviation { get => abbreviation; }
    public Specialization(string name, string abbreviation)
    {
        this.name = name;
        this.abbreviation = abbreviation;
    }
}
