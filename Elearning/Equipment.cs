using System;
public class Equipment
{
    private string name;
    private int price;
    private DateTime registrationDate;

    public Equipment(string name, int price, DateTime? registrationDate = null)
    {
        this.name = name;
        this.price = price;
        this.registrationDate = registrationDate ?? DateTime.Now;
    }
}
