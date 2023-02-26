using Microsoft.VisualBasic;
using System;

namespace Elearning
{

    /*https://docs.google.com/document/d/1yBWzXRuxmOQiPQs9TyNx8tNgq6nWF42Sjn-mgT_-5nY/edit?usp=sharing*/

    public class Post
    {
        private readonly string name;
        private readonly int salary;
        private readonly Division division;

        public string Name { get => name; }
        public int Salary { get => salary; }
        public Division Division { get => division; }
        public Post(string name, int salary, Division division)
        {
            this.name = name;
            this.salary = salary;
            this.division = division;
        }
    }
}