using Microsoft.VisualBasic;
using System;

namespace Levakov
{
    public class Theme_LessonType
    {
        struct Struct
        {
            private Theme theme;
            private LessonType lessonType;
            private UInt32 hours;

            public Struct(Theme theme, LessonType lessonType, UInt32 hours)
            {
                this.theme = theme;
                this.lessonType = lessonType;
                this.hours = hours;
            }
        }

        private Theme theme { get; set; }
        private LessonType lessonType { get; set; }
        private UInt32 hours { get; set; }
        private Struct structure { get; set; }
        public Theme_LessonType() : this(null, null, 0) { }
        public Theme_LessonType(Theme theme, LessonType lessonType) : this(theme, lessonType, 0) { }

        public Theme_LessonType(Theme theme, LessonType lessonType, UInt32 hours)
        {
            this.theme = theme;
            this.lessonType = lessonType;
            this.hours = hours;
            this.structure = new Struct(theme, lessonType, hours);
        }

        public void foo() { }
        public void foo(int bar) { }
        public void foo(string bar) { }

        public void Deconstruct(out Theme theme, out LessonType lessonType, out UInt32 hours)
        {
            theme = this.theme;
            lessonType = this.lessonType;
            hours = this.hours;
        }
    }
}
