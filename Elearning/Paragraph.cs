using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Paragraph
    {
        private readonly string name;
        private readonly Theme theme;

        public Paragraph(string name, Theme theme)
        {
            this.name = name;
            this.theme = theme;
        }
    }
}