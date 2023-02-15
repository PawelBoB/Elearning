using Microsoft.VisualBasic;
using System;

namespace Goryachev
{
    public class Post
    {
        struct Struct
        {
            private string name { get; set; }
            private int salary { get; set; }
            private Division division { get; set; }

            public Struct(string name, int salary, Division division)
            {
                this.name = name;
                this.salary = salary;
                this.division = division;
            }
        }
        private string name { get; set; }
        private int salary { get; set; }
        private Division division { get; set; }
        private Struct myStruct;
        public Post(string name, int salary, Division division)
        {
            this.name = name;
            this.salary = salary;
            this.division = division;
            this.myStruct = new Struct(name, salary, division);
        }

        public Post(string name) : this(name, 0, new Division()) { }

        public Post() : this("", 0, new Division()) { }

        public void Deconstruct(out string name, out int salary, out Division division)
        {
            name = this.name;
            salary = this.salary;
            division = this.division;
        }

        public void foo() { }
        public void foo(string bar) { }
        public void foo(int bar) { }
    }
}
