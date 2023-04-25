// https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

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

        public Lesson(DateOnly date, Discipline discipline, Employee employee, Group group, Pair pair, LessonType lessonType)
        {
            Date = date;
            Discipline = discipline;
            Employee = employee;
            Group = group;
            Pair = pair;
            LessonType = lessonType;
        }
    }
}