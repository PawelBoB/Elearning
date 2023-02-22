using Microsoft.VisualBasic;
using System;
//https://docs.google.com/document/d/1yVUsN3kjBq8p0lpNqIPmfKwpoLFw12PQTUwH_bwbODc/edit?usp=share_link

public class Paragraph
{
    private readonly string name;
    public string Name { get { return name; } }

    private readonly Theme theme;
    public Theme Theme { get { return theme; } }

    public Paragraph(string name, Theme theme)
    {
        this.name = name;
        this.theme = theme;
    }
}
