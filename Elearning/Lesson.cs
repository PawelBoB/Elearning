// https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Lesson
    {
        private readonly Discipline discipline;
        private readonly Employee employee;
        private readonly Group group;
        private readonly Pair pair;
        private readonly LessonType lessonType;
        public Lesson(Discipline discipline, Employee employee, Group group, Pair pair, LessonType lessonType)
        {
            this.discipline = discipline;
            this.employee = employee;
            this.group = group;
            this.pair = pair;
            this.lessonType = lessonType;
        }
    }
}