using System;

namespace Elearning
{
    public class Equipment
    {
        private readonly string name;
        private readonly int price;
        private readonly DateTime registrationDate;

        public Equipment(string name, int price, DateTime? registrationDate = null)
        {
            this.name = name;
            this.price = price;
            this.registrationDate = registrationDate ?? DateTime.Now;
        }
    }
}