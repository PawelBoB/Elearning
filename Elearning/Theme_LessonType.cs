// https://docs.google.com/document/d/1WGyoAKQUgPagK48sVgJVWw95ngniPNwjHByhib_R60c

using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Theme_LessonType
    {
        public Theme Theme { get; }
        public LessonType LessonType { get; }
        public UInt16 Hours { get; }


        public Theme_LessonType(Theme theme, LessonType lessonType, UInt16 hours)
        {
            Theme = theme;
            LessonType = lessonType;
            Hours = hours;
        }
    }
}
