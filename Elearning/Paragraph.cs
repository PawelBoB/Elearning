using Microsoft.VisualBasic;
using System;

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