using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class KTP
    {
        public Paragraph Paragraph { get; }
        public LessonType Lessontype { get; }
        public List<Content> Content { get; }
        public int Number { get; }
        public int Hour { get; }

        public KTP(Paragraph paragraph, LessonType lessontype, List<Content> content, int nomer, int chas)
        {
            Paragraph = paragraph;
            Lessontype = lessontype;
            Content = content;
            Number = nomer;
            Hour = chas;
        }
    }
}
