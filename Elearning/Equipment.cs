// https://docs.google.com/document/d/1ynMOoROmPiCWqPt78fnwQoIJKsoAIgdxhzp1VSjatsE

namespace Elearning
{
    public class Equipment
    {
        public string Name { get; }
        public decimal Price { get; }
        public DateOnly SheetDate { get; }

        public Equipment(string name, decimal price, DateOnly sheetDate)
        {
            Name = name;
            Price = price;
            SheetDate = sheetDate;
        }

        public Equipment(string name, decimal price) : this(name, price, DateOnly.FromDateTime(DateTime.Now)) { }
    }
}
