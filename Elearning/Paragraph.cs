using Microsoft.VisualBasic;
using System;

//https://docs.google.com/document/d/1yVUsN3kjBq8p0lpNqIPmfKwpoLFw12PQTUwH_bwbODc/edit?usp=drivesdk

namespace Elearning
{
    public class Paragraph
    {
        public string Name { get; }
        public Theme Theme { get; }

        public Paragraph(string name, Theme theme)
        {
            Name = name;
            Theme = theme;
        }
    }
}
