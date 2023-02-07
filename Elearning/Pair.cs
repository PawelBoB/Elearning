using Microsoft.VisualBasic;
using System;

class Pair
{
    private DateTime beginningsP;
    private DateTime endingP;
    private DateTime beginningsBreak;
    private DateTime endingBreak;
    private Shift shift;

    public Pair(DateTime beginningsP, DateTime endingP, DateTime beginningsBreak, DateTime endingBreak, Shift shift)
    {
        this.beginningsP = beginningsP;
        this.endingP = endingP;
        this.beginningsBreak = beginningsBreak;
        this.endingBreak = endingBreak;
        this.shift = shift;
    }
}
