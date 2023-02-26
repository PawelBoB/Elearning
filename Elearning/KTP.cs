using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class KTP
    {
        private Paragraph paragraph;
        private LessonType lessontype;
        private List<Content> content;
        private int nomer;
        private int chas;

        public KTP(Paragraph paragraph, LessonType lessontype, List<Content> content, int nomer, int chas)
        {
            this.paragraph = paragraph;
            this.lessontype = lessontype;
            this.content = content;
            this.nomer = nomer;
            this.chas = chas;
        }
    }
}
