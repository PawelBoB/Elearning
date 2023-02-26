//https://docs.google.com/document/d/1qCEMkbMRvvHP361IFDeWgSpHfVRUp6BV67nrsjl3fSw/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Discipline
    {
        private readonly string name;
        private readonly string abbreviation;
        public Discipline(string name, string abbreviation)
        {
            this.name = name;
            this.abbreviation = abbreviation;
        }
    }
}