using Microsoft.VisualBasic;
using System;

public class Theme_LessonType
{
    private Theme theme;
    private LessonType lessonType;
    private UInt32 hours;

    public Theme_LessonType(Theme theme, LessonType lessonType, UInt32 hours)
    {
        this.theme = theme;
        this.lessonType = lessonType;
        this.hours = hours;
    }
}