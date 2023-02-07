using Microsoft.VisualBasic;
using System;

public class Lesson
{
    private Discipline discipline;
    private Employee employee;
    private Group group;
    private Pair pair;
    private LessonType lessonType;
    public Lesson(Discipline discipline, Employee employee, Group group, Pair pair, LessonType lessonType)
    {
        this.discipline = discipline;
        this.employee = employee;
        this.group = group;
        this.pair = pair;
        this.lessonType = lessonType;
    }
}
