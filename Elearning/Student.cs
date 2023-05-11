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
        public Student() : this("Noname", "Noname", "Noname")
        { }
        public Student(string lastName, string name, string middleName) : this(lastName, name, middleName, new Group(), new DateOnly(0, 0, 0))
        { }
        public Student(string lastName, string name, string middleName, Group group, DateOnly birthday)
        {
            LastName = lastName;
            Name = name;
            MiddleName = middleName;
            Group = group;
            Birthday = birthday;
        }
        public void Deconstruct(out string studentlastName, out string studentname, out string studentmiddleName, out Group studentgroup, out DateOnly studentbirthday)
        {
            studentlastName = LastName;
            studentname = Name;
            studentmiddleName = MiddleName;
            studentgroup = Group;
            studentbirthday = Birthday;
        }
        static public void PrintName(string Name)
        {
            Console.WriteLine($"Привет, {Name}.");
        }
        static public void PrintName(string Name, string LasrName)
        {
            Console.WriteLine($"{LasrName} {Name}, привет.");
        }
        static public void PrintName(string Name, string LasrName, string MiddleName)
        {
            Console.WriteLine($"{LasrName} {Name} {MiddleName}, здравствуйте.");
        }
        readonly struct StudentStruct
        {
            public string LastName { get; }
            public string Name { get; }
            public string MiddleName { get; }
            public Group Group { get; }
            public DateOnly Birthday { get; }
            public StudentStruct(Student student)
            {
                LastName = student.LastName;
                Name = student.Name;
                MiddleName = student.MiddleName;
                Group = student.Group;
                Birthday = student.Birthday;
            }
        }
    }
}
