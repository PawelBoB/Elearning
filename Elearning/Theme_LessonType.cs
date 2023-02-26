// https://docs.google.com/document/d/1WGyoAKQUgPagK48sVgJVWw95ngniPNwjHByhib_R60c

using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Theme_LessonType
    {
        private readonly Theme theme;
        private readonly LessonType lessonType;
        private readonly uint hours;

        public Theme Theme { get => theme; }
        public LessonType LessonType { get => lessonType; }
        public uint Hours { get => hours; }


        public Theme_LessonType(Theme theme, LessonType lessonType, uint hours)
        {
            this.theme = theme;
            this.lessonType = lessonType;
            this.hours = hours;
        }
    }
}
