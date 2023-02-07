using Microsoft.VisualBasic;
using System;

class Pair
{
    private DateTime beginningsP;
    private TimeSpan endingP;
    private TimeSpan beginningsBreak;
    private TimeSpan endingBreak;
    private Shift shift;

    public Pair(TimeSpan beginningsP, TimeSpan endingP, TimeSpan beginningsBreak, TimeSpan endingBreak, Shift shift)
    {
        this.beginningsP = beginningsP;
        this.endingP = endingP;
        this.beginningsBreak = beginningsBreak;
        this.endingBreak = endingBreak;
        this.shift = shift;
    }
}
