//https://docs.google.com/document/d/1r4OjKXg5_5yj6ibHB778UEF5Z1nbUqGdXjpQXbTGWiQ/edit?usp=sharing
using Microsoft.VisualBasic;
using System;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;


namespace Elearning
{
    public class Pair       // Pair num = new Pair(new TimeSpan (12,23,04)); - ввод времени
    {
        public TimeSpan BeginningsP { get; }
        public TimeSpan EndingP { get; }
        public TimeSpan BeginningsBreak { get; }
        public TimeSpan EndingBreak { get; }
        public Shift Shift { get; }
       
        public Pair() : this(new TimeSpan(), new TimeSpan(), new TimeSpan()) { }
        public Pair(TimeSpan eginningsP, TimeSpan endingP, TimeSpan beginningsBreak) : this(eginningsP, endingP, beginningsBreak, new TimeSpan(), new Shift("")) { }
        public Pair(TimeSpan beginningsP, TimeSpan endingP, TimeSpan beginningsBreak, TimeSpan endingBreak, Shift shift)
        {
            BeginningsP = beginningsP;
            EndingP = endingP;
            BeginningsBreak = beginningsBreak;
            EndingBreak = endingBreak;
            Shift = shift;
        }
        public void Deconstract(out TimeSpan beginningsP, out TimeSpan endingP, out TimeSpan beginningsBreak, out TimeSpan endingBreak, out Shift shift)
        {
            beginningsP = BeginningsP;
            endingP = EndingP;
            beginningsBreak = BeginningsBreak;
            endingBreak = EndingBreak;
            shift = Shift;
        }
    }
}
