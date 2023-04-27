//https://docs.google.com/document/d/1r4OjKXg5_5yj6ibHB778UEF5Z1nbUqGdXjpQXbTGWiQ/edit?usp=sharing
using Microsoft.VisualBasic;
using System;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;


namespace Elearning
{
    public class Pair       // Pair num = new Pair(new TimeSpan (12,23,04)); - ввод времени
    {
        public Pair()
        {
            BeginningsP = new TimeSpan(00, 00, 00);
            EndingP = new TimeSpan(00, 00, 00);
            BeginningsBreak = new TimeSpan(00, 00, 00);
            EndingBreak = new TimeSpan(00, 00, 00);
            Shift = new ("нет данных");
        }
        
        public TimeSpan BeginningsP { get; }
        public TimeSpan EndingP { get; }
        public TimeSpan BeginningsBreak { get; }
        public TimeSpan EndingBreak { get; }
        public Shift Shift { get; }
        public Pair(TimeSpan beginningsP, TimeSpan endingP, TimeSpan beginningsBreak, TimeSpan endingBreak, Shift shift)
        {
            BeginningsP = beginningsP;
            EndingP = endingP;
            BeginningsBreak = beginningsBreak;
            EndingBreak = endingBreak;
            Shift = shift;
        }
        
    }
}
