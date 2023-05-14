using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Employee
    {
        private readonly string fam;
        private readonly string name;
        private readonly string otch;
        private readonly Post post;

        public Employee(string fam, string name, string otch, Post post)
        {
            this.fam = fam;
            this.name = name;
            this.otch = otch;
            this.post = post;
        }
#pragma warning disable CS8618 // ѕоле, не допускающее значени€ NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. ¬озможно, стоит объ€вить поле как допускающее значени€ NULL.
        public Employee() //«аглушка дл€ конструктора класса Group
#pragma warning restore CS8618 // ѕоле, не допускающее значени€ NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. ¬озможно, стоит объ€вить поле как допускающее значени€ NULL.
        { }
    }
}