// https://docs.google.com/document/d/1yBWzXRuxmOQiPQs9TyNx8tNgq6nWF42Sjn-mgT_-5nY/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Post
    { 
        public string Name { get; }
        public float Salary { get; }
        public Division Division { get; }

        public Post(string name, int salary, Division division)
        {
            Name = name;
            Salary = salary;
            Division = division;
        }
    }
}
