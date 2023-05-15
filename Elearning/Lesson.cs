// https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0/edit?usp=sharing
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace Elearning
{
    public class Lesson
    {
        public DateOnly Date { get; }
        public Discipline Discipline { get; }
        public Employee Employee { get; }
        public Group Group { get; }
        public Pair Pair { get; }
        public LessonType LessonType { get; }

        public Lesson() : this(new Discipline(), new Employee()) { }
        public Lesson(Discipline discipline, Employee employee) : this(discipline, employee, new Group(), new Pair(), new LessonType()) { }
        public Lesson(Discipline discipline, Employee employee, Group group, Pair pair, LessonType lessonType) : this(DateOnly.FromDateTime(DateTime.Now), discipline, employee, group, pair, lessonType) { }
        public Lesson(DateOnly date, Discipline discipline, Employee employee, Group group, Pair pair, LessonType lessonType)
        {
            Date = date;
            Discipline = discipline;
            Employee = employee;
            Group = group;
            Pair = pair;
            LessonType = lessonType;
        }
        public void Deconstruct(out DateOnly date, out Discipline discipline, out Employee employee, out Group group, out Pair pair, out LessonType lessonType)
        {
            date = Date;
            discipline = Discipline;
            employee = Employee;
            group = Group;
            pair = Pair;
            lessonType = LessonType;



        }

    }
}