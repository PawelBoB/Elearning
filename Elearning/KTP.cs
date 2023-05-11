//https://docs.google.com/document/d/1WAYQs71mME22Cx-5ZDXGkQklkuDX9WN2EzqgmVfNSss/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class KTP
    {
        public Paragraph Paragraph { get; }
        public LessonType LessonType { get; }
        public List<Content> Content { get; }
        public byte Number { get; }
        public byte Hour { get; }

        public KTP(Paragraph paragraph, LessonType lessonType, List<Content> content, byte number, byte hour)
        {
            Paragraph = paragraph;
            LessonType = lessonType;
            Content = content;
            Number = number;
            Hour = hour;
        }
    }
}
