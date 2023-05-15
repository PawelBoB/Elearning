//https://docs.google.com/document/d/1qCEMkbMRvvHP361IFDeWgSpHfVRUp6BV67nrsjl3fSw/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Discipline
    {
 
        public string Name { get; }
        public string Abbreviation { get; }

        public Discipline(string name, string abbreviation)
        {
            Name = name;
            Abbreviation = abbreviation;
        }
        public Discipline() : this("no_name", "no_name") { }
    }
}
