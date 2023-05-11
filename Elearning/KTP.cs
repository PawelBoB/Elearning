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
        public uint Number { get; }
        public uint Hour { get; }

        public KTP(Paragraph paragraph, LessonType lessonType, List<Content> content, uint number, uint hour)
        {
            Paragraph = paragraph;
            Lessontype = lessonType;
            Content = content;
            Number = number;
            Hour = hour;
        }
    }
}
