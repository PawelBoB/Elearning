//https://docs.google.com/document/d/1r4OjKXg5_5yj6ibHB778UEF5Z1nbUqGdXjpQXbTGWiQ/edit?usp=sharing
using Microsoft.VisualBasic;
using System;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;


namespace Elearning
{
    public class Pair       // Pair num = new Pair(new TimeSpan (12,23,04)); - ввод времени
    {
        private readonly TimeSpan beginningsP;
        private readonly TimeSpan endingP;
        private readonly TimeSpan beginningsBreak;
        private readonly TimeSpan endingBreak;
        private readonly  Shift shift;

        public Pair()
        {
            beginningsP = new TimeSpan(00, 00, 00);
            endingP = new TimeSpan(00, 00, 00);
            beginningsBreak = new TimeSpan(00, 00, 00);
            endingBreak = new TimeSpan(00, 00, 00);
            shift = (Shift_ ?? "нет данных");
        }
        
        public TimeSpan BeginningsP { get => beginningsP; }
        public TimeSpan EndingP { get => endingP; }
        public TimeSpan BeginningsBreak { get => beginningsBreak; }
        public TimeSpan EndingBreak { get => endingBreak; }
        public Shift Shift_ { get =>  shift; }
        public Pair(TimeSpan beginningsP, TimeSpan endingP, TimeSpan beginningsBreak, TimeSpan endingBreak, Shift shift)
        {
            this.beginningsP = beginningsP;
            this.endingP = endingP;
            this.beginningsBreak = beginningsBreak;
            this.endingBreak = endingBreak;
            this.shift = shift;
        }
        
    }
}