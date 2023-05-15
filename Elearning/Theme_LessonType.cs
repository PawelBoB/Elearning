// https://docs.google.com/document/d/1WGyoAKQUgPagK48sVgJVWw95ngniPNwjHByhib_R60c

using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Theme_LessonType
    {
        public struct Structure
        {
            public Theme Theme { get; set; }
            public LessonType LessonType { get; set; }
            public UInt16 Hours { get; set; }

            public Structure(Theme theme, LessonType lessonType, UInt16 hours)
            {
                Theme = theme;
                LessonType = lessonType;
                Hours = hours;
            }
        }

        public Theme Theme { get; set; }
        public LessonType LessonType { get; set; }
        public UInt16 Hours { get; set; }
        public Structure Theme_LessonTypeStructure { get; set; }

        public Theme_LessonType(Theme theme, LessonType lessonType, UInt16 hours)
        {
            Theme = theme;
            LessonType = lessonType;
            Hours = hours;
            Theme_LessonTypeStructure = new Structure(theme, lessonType, hours);
        }

        public Theme_LessonType(Theme theme, LessonType lessonType) : this(theme, lessonType, 0) { }

        public Theme_LessonType() : this(new Theme(""), new LessonType(""), 0) { }

        public void Deconstruct(out Theme theme, out LessonType lessonType, out UInt16 hours)
        {
            theme = Theme;
            lessonType = LessonType;
            hours = Hours;
        }

        public static void Foo() { }
        public static void Foo(int value) { Console.WriteLine(value); }
        public static void Foo(string value) { Console.WriteLine(value); }
    }
}
