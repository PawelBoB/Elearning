// https://docs.google.com/document/d/1pDw7bbBJDmeqT8VVwp68BSOF_4yd9cNb9xpH_q2KW0E/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

namespace Elearning
{
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
#pragma warning disable CS8618 // ѕоле, не допускающее значени€ NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. ¬озможно, стоит объ€вить поле как допускающее значени€ NULL.
        public Specialization() //«аглушка дл€ конструктора класса Group
#pragma warning restore CS8618 // ѕоле, не допускающее значени€ NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. ¬озможно, стоит объ€вить поле как допускающее значени€ NULL.
        { }
    }
}