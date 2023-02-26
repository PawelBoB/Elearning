//https://docs.google.com/document/d/1r4OjKXg5_5yj6ibHB778UEF5Z1nbUqGdXjpQXbTGWiQ/edit?usp=sharing
using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Pair       // Pair num = new Pair(new TimeSpan (12,23,04)); - ввод времени
    {
        private readonly TimeSpan beginningsP;
        private readonly TimeSpan endingP;
        private readonly TimeSpan beginningsBreak;
        private readonly TimeSpan endingBreak;
        private readonly Shift shift;

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