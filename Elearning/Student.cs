using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Student
    {
        private readonly string fam;
        private readonly string name;
        private readonly string otch;
        private readonly Group group;
        private readonly DateTime? birthday;

        public Student(string fam, string name, string otch, Group group, DateTime? birthday = null)
        {
            this.fam = fam;
            this.name = name;
            this.otch = otch;
            this.group = group;
            this.birthday = birthday == null ? DateTime.Now : birthday;
        }
    }
}