//https://docs.google.com/document/d/1FrtPd2tz85cDVhZCYXqL0wrByPjNbd6kUbjXzOzfLPc/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Student
    {
        public string LastName { get; }
        public string Name { get; }
        public string MiddleName { get; }
        public Group Group { get; }
        public DateOnly Birthday { get; }

        public Student(string lastName, string name, string middleName, Group group, DateOnly birthday)
        {
            LastName = lastName;
            Name = name;
            MiddleName = middleName;
            Group = group;
            Birthday = birthday;
        }
    }
}
