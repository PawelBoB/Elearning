//https://docs.google.com/document/d/1mwSWGxZfPEK4Ysyh9TJ4A_Ym1bew2ttNGWbMpK9y_zc/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class LessonType
    {
        public string Name { get; }
        public LessonType(string name)
        {
            Name= name;
        }
        public LessonType() : this("no_name"){ }
    }
}